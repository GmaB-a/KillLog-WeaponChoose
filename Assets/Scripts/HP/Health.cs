using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int EntityHealth = 100;

    public void ReceiveDamage(int IncomingDamage, GameObject WhoDidDamage)
    {
        EntityHealth -= IncomingDamage;

        if (EntityHealth <= 0)
        {
            Die(WhoDidDamage);
        }
    }

    public GameObject KillLogPanel;
    public GameObject KillLogTemplate;
    private void Die(GameObject Killer)
    {
        GameObject KillLogClone = Instantiate(KillLogTemplate);
        KillLogClone.name = "KillLogClone";
        KillLogClone.transform.parent = KillLogPanel.transform;
        KillLogClone.SetActive(true);
        KillLogClone.GetComponent<RectTransform>().localScale = KillLogTemplate.GetComponent<RectTransform>().localScale;
        KillLogScript KillLogCloneScript = KillLogClone.GetComponent<KillLogScript>();
        KillLogCloneScript.TheKiller = Killer;
        KillLogCloneScript.Killed = gameObject;
        Destroy(gameObject);
    }
}

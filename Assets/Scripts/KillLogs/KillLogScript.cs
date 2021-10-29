using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillLogScript : MonoBehaviour
{
    public string Killer;
    public string Killed;
    private float TimeOnDespawn = 5f;

    private void Start()
    {
        Text KillerText = gameObject.transform.Find("Killer").GetComponent<Text>();
        Text MidText = gameObject.transform.Find("MidText").GetComponent<Text>();
        Text KilledText = gameObject.transform.Find("Killed").GetComponent<Text>();
        KillerText.text = Killer;
        KilledText.text = Killed;
        if (Killed.Contains("BOSS"))
        {
            KillerText.color = Color.red;
            MidText.color = Color.red;
            KilledText.color = Color.red;
            TimeOnDespawn = 20f;
        }
        if (gameObject.name != "KillLogTemplate")
        {
            Destroy(gameObject, TimeOnDespawn);
        }
    }
}

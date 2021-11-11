using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int EntityHealth = 100;

    public void ReceiveDamage(int IncomingDamage, GameObject DamageInstigator)
    {
        EntityHealth -= IncomingDamage;

        if (EntityHealth <= 0)
        {
            Die(DamageInstigator.transform.parent.name, gameObject.name);
        }
    }
   
    private void Die(string KillerName, string KilledName)
    {
        KillLogInstigator.GetInstance().InstantiateKillLog(KillerName, KilledName);
        Destroy(gameObject);
    }
}

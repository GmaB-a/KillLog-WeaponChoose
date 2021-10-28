using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthText : MonoBehaviour
{
    private void Update()
    {
        int NewEnemyHealth = gameObject.transform.parent.GetComponent<Health>().EntityHealth;
        gameObject.GetComponent<TextMesh>().text = "" + NewEnemyHealth;
    }
}

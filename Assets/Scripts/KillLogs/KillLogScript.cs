using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillLogScript : MonoBehaviour
{
    public GameObject TheKiller;
    public GameObject Killed;
    private float TimeOnDespawn = 5f;

    private void Start()
    {
        gameObject.transform.GetChild(0).GetComponent<Text>().text = TheKiller.name;
        gameObject.transform.GetChild(2).GetComponent<Text>().text = Killed.name;
        if (Killed.tag == "BOSS")
        {
            gameObject.transform.GetChild(0).GetComponent<Text>().color = Color.red;
            gameObject.transform.GetChild(2).GetComponent<Text>().color = Color.red;
            TimeOnDespawn = 20f;
        }
        if (gameObject.name != "KillLogTemplate")
        {
            Destroy(gameObject, TimeOnDespawn);
        }
    }
}

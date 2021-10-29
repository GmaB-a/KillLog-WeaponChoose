using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillLogInstigator : MonoBehaviour
{
    private static KillLogInstigator Instance;
    public static KillLogInstigator GetInstance() => Instance;
    private void Awake()
    {
        Instance = this;
    }
    public GameObject KillLogTemplate;
    public void InstantiateKillLog(string Killer, string Killed)
    {
        GameObject KillLogClone = Instantiate(KillLogTemplate);
        KillLogClone.name = "KillLogClone";
        KillLogClone.transform.parent = gameObject.transform;
        KillLogClone.SetActive(true);
        KillLogClone.GetComponent<RectTransform>().localScale = KillLogTemplate.GetComponent<RectTransform>().localScale;
        KillLogScript KillLogCloneScript = KillLogClone.GetComponent<KillLogScript>();
        KillLogCloneScript.Killer = Killer;
        KillLogCloneScript.Killed = Killed;
    }
}

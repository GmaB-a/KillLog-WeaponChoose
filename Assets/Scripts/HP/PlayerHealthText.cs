using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthText : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    private static PlayerHealthText Instance;
    public static PlayerHealthText GetInstance() => Instance;
    private void Awake()
    {
        Instance = this;
    }

    public void Update()
    {
        gameObject.GetComponent<Text>().text = "" + Player.GetComponent<Health>().EntityHealth;
    }
}

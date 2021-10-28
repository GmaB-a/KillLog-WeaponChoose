using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetWeaponAsAChild : MonoBehaviour
{
    public GameObject Player;
    void Start()
    {
        Player = GameObject.Find("Player");
        gameObject.transform.SetParent(Player.transform);
        gameObject.transform.position = Player.transform.GetChild(2).position;
    }
    private void Update()
    {
        gameObject.transform.rotation = Player.transform.GetChild(0).rotation;
    }
}

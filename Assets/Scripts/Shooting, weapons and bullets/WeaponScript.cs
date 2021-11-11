using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public WeaponData ThisWeaponData;
    GameObject Player;
    private void Start()
    {
        Player = GameObject.Find("Player");
        gameObject.transform.SetParent(Player.transform);
        gameObject.transform.position = Player.transform.Find("WeaponPosition").position;
    }
    private void Update()
    {
        Rotate();
    }

    void Rotate()
    {
        gameObject.transform.rotation = Camera.main.transform.rotation;
    }
}

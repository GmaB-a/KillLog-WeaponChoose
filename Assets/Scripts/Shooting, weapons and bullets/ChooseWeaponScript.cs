using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseWeaponScript : MonoBehaviour
{
    public GameObject Player;
    [SerializeField] private GameObject FAMAS;
    [SerializeField] private GameObject AK47;
    [SerializeField] private GameObject UZI;
    public void WeaponChoosed(string Weapon)
    {
        GameObject ChosenWeapon;
        switch (Weapon)
        {
            case "FAMAS":
                ChosenWeapon = FAMAS;
                break;
            case "AK-47":
                ChosenWeapon = AK47;
                break;
            default:
                ChosenWeapon = UZI;
                break;
        }
        GameObject InstantiatedWeapon = Instantiate(ChosenWeapon);
        Cursor.lockState = CursorLockMode.Locked;
        Destroy(gameObject);
    }
}

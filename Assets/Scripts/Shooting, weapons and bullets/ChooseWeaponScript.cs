using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseWeaponScript : MonoBehaviour
{
    public void WeaponChoosed(GameObject ChosenWeapon)
    {
        GameObject InstantiatedWeapon = Instantiate(ChosenWeapon);
        Cursor.lockState = CursorLockMode.Locked;
        Destroy(gameObject);
    }
}

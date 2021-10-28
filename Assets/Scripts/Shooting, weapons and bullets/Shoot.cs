using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject Bullet;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootBullet(gameObject.transform.position);
        }
    }
    void ShootBullet(Vector3 position)
    {
        GameObject NewBullet = Instantiate(Bullet, position, Quaternion.identity);
        NewBullet.GetComponent<BulletScript>().WhoShot = gameObject;
    }
}

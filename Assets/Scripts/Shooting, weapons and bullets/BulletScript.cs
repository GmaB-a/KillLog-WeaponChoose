using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject ShotInstigator;
    [SerializeField] private float Force;
    [SerializeField] private int Damage;
    private void Start()
    {
        Collider ThisCollider = gameObject.GetComponent<Collider>();
        Physics.IgnoreCollision(ShotInstigator.GetComponent<Collider>(), ThisCollider);
        Physics.IgnoreCollision(ShotInstigator.transform.parent.GetComponent<Collider>(), ThisCollider);
        Damage = ShotInstigator.GetComponent<WeaponScript>().ThisWeaponData.Damage;
        GameObject ShotInstigatorsCamera = Camera.main.gameObject;

        Ray ray = new Ray();
        ray.origin = ShotInstigatorsCamera.transform.position;
        ray.direction = ShotInstigatorsCamera.transform.forward;

        Rigidbody BulletPhysics = gameObject.GetComponent<Rigidbody>();
        BulletPhysics.AddForce(ray.direction * Force);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject != ShotInstigator && other.gameObject.GetComponent<Health>() != null)
        {
            other.gameObject.GetComponent<Health>().ReceiveDamage(Damage, ShotInstigator);
        }
        Destroy(gameObject);
    }
}

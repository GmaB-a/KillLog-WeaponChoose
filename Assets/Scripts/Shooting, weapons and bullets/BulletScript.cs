using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject ShotInstigator;
    [SerializeField] private float Force;
    private void Start()
    {
        GameObject ShotInstigatorsCamera = ShotInstigator.GetComponentInChildren<MouseLook>().gameObject;

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
            other.gameObject.GetComponent<Health>().ReceiveDamage(10, ShotInstigator);
        }
    }
}

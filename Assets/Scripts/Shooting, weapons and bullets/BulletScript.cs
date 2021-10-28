using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject WhoShot;
    [SerializeField] private float Force;
    private void Start()
    {
        GameObject WhoShotCamera = WhoShot.GetComponentInChildren<MouseLook>().gameObject;

        Ray ray = new Ray();
        ray.origin = WhoShotCamera.transform.position;
        ray.direction = WhoShotCamera.transform.forward;

        Rigidbody BulletPhysics = gameObject.GetComponent<Rigidbody>();
        BulletPhysics.AddForce(ray.direction * Force);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject != WhoShot && other.gameObject.GetComponent<Health>() != null)
        {
            other.gameObject.GetComponent<Health>().ReceiveDamage(10, WhoShot);
        }
    }
}

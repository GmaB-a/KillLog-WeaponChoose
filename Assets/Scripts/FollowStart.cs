using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowStart : MonoBehaviour
{
    EnemyWalking EW;
    private void Start()
    {
        EW = gameObject.transform.parent.GetComponent<EnemyWalking>();
    }

    private void OnTriggerStay(Collider other)
    {
        EW.StartFollowing(other.gameObject);
    }
}

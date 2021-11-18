using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyWalking : MonoBehaviour
{
    private NavMeshAgent ThisNMA;
    private bool IsFollowing;
    private GameObject WhoIsBeingFollowed;
    void Start()
    {
        ThisNMA = GetComponent<NavMeshAgent>();
        GetRandomDestination();
    }

    private void Update()
    {
        if (ThisNMA.remainingDistance <= 2 && !IsFollowing)
        {
            GetRandomDestination();
        }
        if (ThisNMA.remainingDistance <= 2 && IsFollowing)
        {
            ThisNMA.SetDestination(WhoIsBeingFollowed.transform.position);
        }
    }

    void GetRandomDestination()
    {
        ThisNMA.SetDestination(new Vector3(Random.Range(-230, 230), transform.position.y, Random.Range(-230, 230)));
    }

    public void StartFollowing(GameObject WhoNeedsToBeFollowed)
    {
        ThisNMA.SetDestination(WhoNeedsToBeFollowed.transform.position);
        WhoIsBeingFollowed = WhoNeedsToBeFollowed;
        IsFollowing = true;
    }
}

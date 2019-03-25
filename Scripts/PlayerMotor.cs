using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(PlayerController))]
public class PlayerMotor : MonoBehaviour
{

    Transform target;
    NavMeshAgent agent;     // Reference to our NavMeshAgent

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

    }

    void Update()
    {
        if (target != null)
        {
            agent.SetDestination(target.position);
            FaceTarget();
        }
    }

        
   public void MoveToPoint (Vector3 point)
    {
        agent.SetDestination(point);
        
    }

    public void FollowTarget (Interactable newTarget)
    {
        // set stopping distance 
        agent.stoppingDistance = newTarget.radius * 0.8f;
        target = newTarget.transform;
        FaceTarget();
    }


    public void StopFollowingTarget ()
    {
        agent.stoppingDistance = 0f;
        target = null;
     }

    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }


}
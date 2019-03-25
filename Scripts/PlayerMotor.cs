using UnityEngine;
using UnityEngine.AI;

/* Code partly of Brackeys Youtube Tutorial 
 * https://www.youtube.com/watch?v=S2mK6KFdv0I
 */

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(PlayerController))]
public class PlayerMotor : MonoBehaviour
{

    Transform target;
    NavMeshAgent agent;     // Reference to our NavMeshAgent

    void Start()
    {
        // get NavMeshAgent
        agent = GetComponent<NavMeshAgent>();

    }

    void Update()
    {
        // move to target if something's hit
        if (target != null)
        {
            agent.SetDestination(target.position);
            FaceTarget();
        }
    }

   // move to point where player clicked     
   public void MoveToPoint (Vector3 point)
    {
        agent.SetDestination(point);
    }

    // follow moving target
    public void FollowTarget (Interactable newTarget)
    {
        // set stopping distance 
        agent.stoppingDistance = newTarget.radius * 0.8f;
        target = newTarget.transform;
        FaceTarget();
    }

    // stop following target if out of range
    public void StopFollowingTarget ()
    {
        agent.stoppingDistance = 0f;
        target = null;
     }

    // make player look in target direction
    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }


}

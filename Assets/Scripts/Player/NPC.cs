using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{
    public Transform target; // дверь дома или другая цель
    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (CanReachTarget(target.position))
        {
            agent.SetDestination(target.position);
        }
        else
        {
            Vector3 newPosition = FindNewPath(target.position);
            agent.SetDestination(newPosition);
        }
    }

    private bool CanReachTarget(Vector3 targetPosition)
    {
        NavMeshPath path = new NavMeshPath();
        agent.CalculatePath(targetPosition, path);
        return path.status != NavMeshPathStatus.PathPartial;
    }

    private Vector3 FindNewPath(Vector3 targetPosition)
    {
        NavMeshHit hit;
        if (NavMesh.SamplePosition(targetPosition, out hit, 5.0f, NavMesh.AllAreas))
        {
            return hit.position;
        }
        return Vector3.zero;
    }
}
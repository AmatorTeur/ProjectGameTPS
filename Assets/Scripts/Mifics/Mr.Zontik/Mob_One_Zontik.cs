using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mob_One_Zontik : Zontic_Mob
{
    public List<Transform> patrolPoints;
    private NavMeshAgent _navMeshAgent;

    void Start()
    {
        InitComponentLinks();

        PickNewPatrolPoint();
    }

    void Update()
    {
        PatrolUpdate();
    }

    private void InitComponentLinks()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();

    }

    private void PickNewPatrolPoint()
    {
        _navMeshAgent.destination = patrolPoints[Random.Range(0, patrolPoints.Count)].position;

    }

    private void PatrolUpdate()
    {
        if (_navMeshAgent.remainingDistance == 0)
        {
            PickNewPatrolPoint();

        }

    }
}

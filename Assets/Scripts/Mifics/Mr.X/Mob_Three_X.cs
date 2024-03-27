using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mob_Three_X : XMob
{
    public List<Transform> patrolPoints;
    private NavMeshAgent _navMeshAgent;

    public float waitTime = 3f;
    private bool isWait = false;

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
        isWait = false;

    }

    private void PatrolUpdate()
    {
        if (!_navMeshAgent.pathPending && _navMeshAgent.remainingDistance < 0.5f && !isWait)
        {
            isWait = true;
            StartCoroutine(WaitAndPickNewPatrolPoint());

        }
    }

    IEnumerator WaitAndPickNewPatrolPoint()
    {
        yield return new WaitForSeconds(waitTime);
        PickNewPatrolPoint();
    }
}

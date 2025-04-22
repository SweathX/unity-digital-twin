using UnityEngine;
using UnityEngine.AI;

public class NavMeshWaypointPatrol : MonoBehaviour
{
    public Transform[] waypoints;
    private NavMeshAgent agent;
    private int currentIndex = 0;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        if (waypoints.Length > 0)
        {
            agent.SetDestination(waypoints[currentIndex].position);
        }
    }

    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 1.0f)
        {
            currentIndex = (currentIndex + 1) % waypoints.Length;
            agent.SetDestination(waypoints[currentIndex].position);
        }
    }
}
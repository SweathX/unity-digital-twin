using UnityEngine;
using UnityEngine.AI;

public class StudentWalker : MonoBehaviour
{
    public Transform destination;

    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        RaycastHit hit;
        if (Physics.Raycast(transform.position + Vector3.up * 5, Vector3.down, out hit))
        {
            transform.position = hit.point; // aligne sur le sol
        }

        if (destination != null)
        {
            agent.SetDestination(destination.position);
        }
    }
}
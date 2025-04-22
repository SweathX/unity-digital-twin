using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 5f;

    private Vector3 startPosition;
    private bool goingForward = true;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        Vector3 direction = goingForward ? Vector3.forward : -Vector3.forward;
        transform.Translate(direction * speed * Time.deltaTime);

        float movedDistance = Vector3.Distance(transform.position, startPosition);
        if (movedDistance >= distance)
        {
            goingForward = !goingForward;
        }
    }
}
using UnityEngine;

public class TESTSCRIPT : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;
    public float avoidanceRadius = 2f;
    public LayerMask obstacleLayer;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Calculate direction towards the target
        Vector2 direction = target.position - transform.position;
        direction.Normalize();

        // Check for obstacles in the path
        Collider2D[] obstacles = Physics2D.OverlapCircleAll(transform.position, avoidanceRadius, obstacleLayer);
        Vector2 avoidanceForce = Vector2.zero;

        foreach (Collider2D obstacle in obstacles)
        {
            Vector2 avoidanceDirection = obstacle.transform.position - transform.position;
            avoidanceDirection.Normalize();
            avoidanceForce -= avoidanceDirection;
        }

        // Calculate the desired velocity based on the speed and avoidance force
        Vector2 desiredVelocity = (direction + avoidanceForce) * speed;

        // Calculate the change in velocity required to reach the desired velocity
        Vector2 velocityChange = desiredVelocity - rb.velocity;

        // Apply the change in velocity to the rigidbody
        rb.AddForce(velocityChange, ForceMode2D.Impulse);
    }
}
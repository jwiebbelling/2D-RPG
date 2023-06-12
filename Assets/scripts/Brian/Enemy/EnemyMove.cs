using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Calculate direction towards the target
        Vector2 direction = target.position - transform.position;

        // Normalize the direction vector
        direction.Normalize();

        // Calculate the desired velocity based on the speed
        Vector2 desiredVelocity = direction * speed;

        // Calculate the change in velocity required to reach the desired velocity
        Vector2 velocityChange = desiredVelocity - rb.velocity;

        // Apply the change in velocity to the rigidbody
        rb.AddForce(velocityChange, ForceMode2D.Impulse);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;
    float curSpeed;
    float attackCd;

    private Rigidbody2D rb;

    private void Start()
    {
        curSpeed = speed;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (attackCd > 0)
        {
            attackCd = attackCd - 1 * Time.deltaTime;
            curSpeed = 0;
        }
        else
        {
            curSpeed = speed;
        }

        // Calculate direction towards the target
        Vector2 direction = target.position - transform.position;

        // Normalize the direction vector
        direction.Normalize();

        // Calculate the desired velocity based on the speed
        Vector2 desiredVelocity = direction * curSpeed;

        // Calculate the change in velocity required to reach the desired velocity
        Vector2 velocityChange = desiredVelocity - rb.velocity;

        // Apply the change in velocity to the rigidbody
        rb.AddForce(velocityChange, ForceMode2D.Impulse);
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject == target.gameObject && attackCd <= 0)
        {
            collision.gameObject.GetComponent<PlayerStatus>().GetHit(gameObject.GetComponent<EnemyStatus>().GetAttackDmg());
            attackCd = gameObject.GetComponent<EnemyStatus>().GetAttackDmg();
        }
        else
        {

        }
    }
}

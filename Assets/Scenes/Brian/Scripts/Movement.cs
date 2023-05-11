using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] KeyCode up = KeyCode.W;
    [SerializeField] KeyCode down = KeyCode.S;
    [SerializeField] KeyCode left = KeyCode.A;
    [SerializeField] KeyCode right = KeyCode.D;
    public float speed = 5;
    float ySpeed;
    float xSpeed;
    float yMult = 1f;
    float xMult = 1f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(up))
        {
            ySpeed = speed;
            xMult = 0.7f;
        }
        else if (Input.GetKey(down))
        {
            ySpeed = 0 - speed;
            xMult = 0.7f;
        }
        else
        {
            ySpeed = 0;
            xMult = 1f;
            //rb.velocity = new Vector2(rb.velocity.x, 0); //this stops it from working
        }

        if (Input.GetKey(right))
        {
            xSpeed = speed;
            yMult = 0.7f;
        }
        else if (Input.GetKey(left))
        {
            xSpeed = 0 - speed;
            yMult = 0.7f;
        }
        else
        {
            xSpeed = 0;
            yMult = 1f;
        }

        rb.velocity = new Vector2(xSpeed * xMult, ySpeed * yMult);
    }
}

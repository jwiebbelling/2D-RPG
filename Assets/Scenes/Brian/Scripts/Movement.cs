using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] KeyCode up= KeyCode.W;
    [SerializeField] KeyCode down = KeyCode.S;
    [SerializeField] KeyCode left = KeyCode.A;
    [SerializeField] KeyCode right = KeyCode.D;
    public float speed = 100;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);
        if (Input.GetKey(up))
        {
            rb.velocity = new Vector2(rb.velocity.x, speed * Time.deltaTime) ;
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, 0); //this stops it from working
        }

        if (Input.GetKey(down))
        {
            rb.velocity = new Vector2(rb.velocity.x, 0 - speed * Time.deltaTime);
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, 0); //this stops it from working
        }
    }
}

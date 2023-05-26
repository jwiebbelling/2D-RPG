using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Vector2 startDir = new Vector2(3, 0);
    private Transform newTransform;
    [SerializeField] float bulletSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Rigidbody2D>().velocity = startDir;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
    }
    public void setDir(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed * direction.x, bulletSpeed * direction.y);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Vector2 startDir = new Vector2(3, 0);
    private Transform newTransform;
    [SerializeField] float bulletSpeed = 5;
    [SerializeField] float lifeTime = 5;
    [SerializeField] int damage = 2;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
        //GetComponent<Rigidbody2D>().velocity = startDir;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Enemy's"))
        {
            collision.GetComponent<EnemyStatus>().IsHit(damage);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
    public void setDir(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed * direction.x, bulletSpeed * direction.y);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogValuesEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Enemy Velocity: " + GetComponent<Rigidbody2D>().velocity + ", Enemy Position: " + gameObject.transform.position);
    }
}

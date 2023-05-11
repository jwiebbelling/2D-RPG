using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    Vector2 mousePosition;

    [SerializeField] GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        // convert mouse position into world coordinates
        //Vector2 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // get direction you want to point at
        Vector2 direction = (mousePosition - (Vector2)transform.position).normalized;

        // set vector of transform directly
        transform.up = direction;


        Debug.Log(mousePosition.x);
        Debug.Log(mousePosition.y);
    }
}

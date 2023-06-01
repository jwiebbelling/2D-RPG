using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float detectionRange;
    [SerializeField] GameObject visableRange;
    [SerializeField] bool seeInfo;
    LineRenderer lineRenderer;
    float distance;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = gameObject.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(gameObject.transform.position, player.transform.position);
        //Debug.Log(distance);

        RaycastHit2D hit = Physics2D.Raycast(transform.position, player.transform.position);
        if (hit.collider != null)
        {
            Debug.Log(hit.collider.name);
            
        }
        Debug.DrawLine(transform.position, player.transform.position);



        visableRange.SetActive(seeInfo);
        if (seeInfo)
        {
            visableRange.transform.localScale = new Vector2(detectionRange * 2, detectionRange * 2) ;
            lineRenderer.SetPosition(0, player.transform.position);
            lineRenderer.SetPosition(1, gameObject.transform.position);
            lineRenderer.startWidth = 0.1f;
            lineRenderer.endWidth = 0.1f;
        }
    }
}

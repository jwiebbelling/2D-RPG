using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    [SerializeField] GameObject player;
    float detectionRange;
    [SerializeField] GameObject visableRange;
    [SerializeField] bool seeInfo;
    public LayerMask ignoreLayerLinecast;
    LineRenderer lineRenderer;
    float distance;
    bool targetPlayer = false;
    bool playerSeen = false;
    float timer;
    float targetTime = 3;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = gameObject.GetComponent<LineRenderer>();
        detectionRange = gameObject.GetComponent<EnemyStatus>().GetDetectionRange();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerSeen)
        {
            this.GetComponent<EnemyMove>().enabled = true;
            Debug.Log("PlayerSeen");
        }
        else
        {
            this.GetComponent<EnemyMove>().enabled = false;
            this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }






        distance = Vector2.Distance(gameObject.transform.position, player.transform.position);
        //Debug.Log(distance);
        RaycastHit2D hit = Physics2D.Linecast(transform.position, player.transform.position, ~ignoreLayerLinecast);
        if (hit.collider != null && hit.collider.gameObject != gameObject)
        {
            if (hit.collider.CompareTag("Wall"))
            {
                if (!playerSeen)
                {
                targetPlayer = false;
                Debug.Log(hit.collider.name);
                }
            }
            else if (hit.collider.CompareTag("Player"))
            {
                Debug.Log(hit.collider.name);
                targetPlayer = true;
            }
        }
        Debug.DrawLine(transform.position, player.transform.position, new Color(255, 0, 255));

        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, detectionRange);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject && colliders[i].gameObject.CompareTag("Player"))
            {
               if (targetPlayer)
                {
                    Debug.Log(colliders[i].gameObject.name);
                    playerSeen = true;
                    timer = targetTime;
                }
               //Debug.Log(colliders[i].gameObject.name);
            }
            else if (playerSeen)
            {
                TimerBegin();
            }
        }
        

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
    void TimerBegin()
    {
        if (timer > 0)
        {
            timer = timer - 1 * Time.deltaTime;
        }
        else
        {
            playerSeen = false;
        }
        //Debug.Log(timer);
    }
}

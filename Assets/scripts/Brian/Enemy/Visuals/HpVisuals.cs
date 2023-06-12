using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpVisuals : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = enemy.transform.position + new Vector3(0, 1, 0);
    }
    public void SetHostEnemy(GameObject hostEnemy)
    {
        enemy = hostEnemy;
    }
}

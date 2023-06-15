using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpVisuals : MonoBehaviour
{
    [SerializeField] GameObject host;
    [SerializeField] GameObject hpFill;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = host.transform.position + new Vector3(0, 0.75f, 0);
        //Debug.Log(host.GetComponent<EnemyStatus>().getHp());
        hpFill.GetComponent<Image>().fillAmount = host.GetComponent<EnemyStatus>().getHp();
    }
    public void SetHostEnemy(GameObject hostEnemy)
    {
        host = hostEnemy;
    }
}

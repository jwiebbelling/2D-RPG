using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpVisualsController : MonoBehaviour
{
    [SerializeField] GameObject hpBar;
    // Start is called before the first frame update
    void Start()
    {
        AssignHp("Enemy's");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AssignHp(string targetTag)
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(targetTag);
        foreach (GameObject obj in objectsWithTag)
        {
            GameObject HpVisual = Instantiate(hpBar, obj.transform.position + new Vector3(0, 0.5f, 0), Quaternion.identity);
            HpVisual.transform.SetParent(transform);
            HpVisual.GetComponent<HpVisuals>().SetHostEnemy(obj.gameObject);
        }
    }
}

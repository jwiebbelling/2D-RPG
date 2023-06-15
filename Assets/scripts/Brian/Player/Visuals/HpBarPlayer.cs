using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBarPlayer : MonoBehaviour
{
    GameObject Player;
    [SerializeField] GameObject hpFill;
    // Start is called before the first frame update
    void Start()
    {
        AssignHp("Player");
    }

    // Update is called once per frame
    void Update()
    {
        hpFill.GetComponent<Image>().fillAmount = Player.GetComponent<PlayerStatus>().GetHp();
    }
    void AssignHp(string targetTag)
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(targetTag);
        foreach (GameObject obj in objectsWithTag)
        {
            Player = obj;
        }
    }
}

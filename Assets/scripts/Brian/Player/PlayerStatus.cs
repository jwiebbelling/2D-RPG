using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    int maxHp = 100;
    int currHp;
    // Start is called before the first frame update
    void Start()
    {
        currHp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currHp);
    }
    public void GetHit(int damage)
    {
        currHp -= damage;
    }
}

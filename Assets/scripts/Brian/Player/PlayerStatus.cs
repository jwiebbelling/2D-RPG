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
        if (currHp == 0)
        {
            Dead();
        }
    }
    public void IsHit(int damage)
    {
        if (currHp - damage < 0)
        {
            currHp = 0;
        }
        else
        {
            currHp -= damage;
        }
    }
    public float GetHp()
    {
        return 1.000f / maxHp * currHp;
    }
    void Dead()
    {
        Destroy(gameObject);
    }
}

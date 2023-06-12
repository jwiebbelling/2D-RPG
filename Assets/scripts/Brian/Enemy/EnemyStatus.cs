using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour
{
    [SerializeField] int MaxHP = 5;
    int currentHP;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHP == 0)
        {
            Debug.Log("dead");
        }
    }

    public void IsHit(int damage)
    {
        if (currentHP - damage < 0)
        {
            currentHP = 0;
        }
        else 
        { 
            currentHP =- damage; 
        }
    }
    public float getHp()
    {
        return (1.00f / MaxHP * currentHP);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour
{
    [SerializeField] int MaxHP = 5;
    [SerializeField] int attackDamage = 1;
    [SerializeField] int attackSpeed = 1;
    [SerializeField] float detectionRange = 2.5f;
    [SerializeField] float movementSpeed = 2.5f;
    GameObject attatchedVisuals;
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
            dead();
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
            currentHP -= damage; 
        }
    }
    public float getHp()
    {
        return (1.000f / MaxHP * currentHP);
    }
    public int GetAttackDmg()
    {
        return (attackDamage);
    }
    public int GetAttackSpd()
    {
        return (attackSpeed);
    }

    void dead()
    {
        Destroy(gameObject);
        Destroy(attatchedVisuals);
    }
    public void SetVisualObj(GameObject obj)
    {
        attatchedVisuals = obj;
    }
    public float GetDetectionRange()
    {
        return detectionRange;
    }
    public float GetMovementSpeed()
    {
        return movementSpeed;
    }
}

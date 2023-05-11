using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    [SerializeField] KeybindsData Data;
    [SerializeField] float attackSpeed = 1;
    [SerializeField] int maxAmmo = 7;
    [SerializeField] float reloadTime = 5;
    [SerializeField] bool fullAuto = false;
    int Ammo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Data.Shoot))
        {
            Debug.Log("shot");
        }
    }
}

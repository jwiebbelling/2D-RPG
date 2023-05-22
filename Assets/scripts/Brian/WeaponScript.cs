using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    [SerializeField] KeybindsData Data;
    [SerializeField] float attackSpeed = 1;
    [SerializeField] int maxAmmo = 7;
    [SerializeField] int spareAmmo = 7;
    [SerializeField] float reloadTime = 5;
    [SerializeField] bool fullAuto = false;
    int Ammo = 7;
    bool canShoot = true;

    float reloadingTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(Data.Shoot) && canShoot)
        {
            if (fullAuto)
            {
                canShoot = true;
            }
            else
            {
                canShoot = false;
            }
            Debug.Log("try shot");

            if (Ammo <= 0)
            {
                Debug.Log("EmptyMag");
            }
            else
            {
                FireBullet();
            }

            Debug.Log(Ammo);
        }
        else if (!Input.GetKey(Data.Shoot))
        {
            canShoot = true;
        }

        if (Input.GetKey(Data.Reload))
        {
            Ammo = maxAmmo;
            Debug.Log("Reloading");
        }
    }
    void FireBullet()
    {
        Ammo = Ammo - 1;
        Debug.Log("actual shot");
    }
}

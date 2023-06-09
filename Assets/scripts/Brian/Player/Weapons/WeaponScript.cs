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
    [SerializeField] GameObject bullet;
    int ammo;
    bool canShoot = true;
    bool currentlyReloading = false;

    float reloadingTimer;

    float attackTimer;
    // Start is called before the first frame update
    void Start()
    {
        ammo = maxAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.rotation.x + "  = X and " + transform.rotation.y + "  = Y and " + transform.rotation.z + "  = Z And" + transform.rotation.w + "  = W");
        if (Input.GetKey(Data.Shoot) && canShoot && !currentlyReloading)
        {
            if (attackTimer <= 0)
            {
                if (fullAuto)
                {
                    canShoot = true;
                }
                else
                {
                    canShoot = false;
                }
                //Debug.Log("try shot");

                if (ammo <= 0)
                {
                    Debug.Log("EmptyMag");
                }
                else
                {
                    FireBullet();
                }
                attackTimer = attackSpeed;
                //Debug.Log(ammo);
            }
        }
        else if (!Input.GetKey(Data.Shoot))
        {
            canShoot = true;
        }
        if (spareAmmo > 0)
        {
            if (Input.GetKey(Data.Reload) && !currentlyReloading)
            {
                currentlyReloading = true;
                //Debug.Log("Reloading");
                reloadingTimer = reloadTime;
            }
            else if (reloadingTimer <= 0 && currentlyReloading)
            {
                currentlyReloading = false;

                AmmoReloading();

                Debug.Log("Done Reloading");
            }
        }
        if (reloadingTimer > 0)
        {
            reloadingTimer = reloadingTimer - 1 * Time.deltaTime;
        }
        if (attackTimer > 0)
        {
            attackTimer = attackTimer - 1 * Time.deltaTime;
        }

        //Debug.Log(reloadingTimer + " RelTime Remaining");
    }
    void FireBullet()
    {
        ammo = ammo - 1;
        GameObject spawnedBullet = Instantiate(bullet, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);
        spawnedBullet.GetComponent<BulletScript>().setDir(gameObject.GetComponentInParent<PlayerRotation>().getDir());
        //Debug.Log("actual shot");
        
    }
    void AmmoReloading()
    {
        if (ammo + spareAmmo > maxAmmo)
        {
            spareAmmo = spareAmmo - maxAmmo;
            ammo = ammo + maxAmmo;
        }
        else
        {
            ammo = ammo + spareAmmo;
            spareAmmo = spareAmmo - spareAmmo;
        }
    }
    public void DisableWeapon()
    {
        currentlyReloading = false;
        reloadingTimer = 0;
        gameObject.SetActive(false);
    }
}

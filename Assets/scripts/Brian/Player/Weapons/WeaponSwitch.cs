using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    [SerializeField] KeybindsData Data;
    [SerializeField] GameObject[] weapons;
    int selectedWeapon = 0;
    // Start is called before the first frame update
    void Start()
    {
        ChangeWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(selectedWeapon);
        if (Input.GetKeyDown(Data.SwitchWeaponUp) && selectedWeapon < weapons.Length - 1)
        {
            selectedWeapon += 1;
            ChangeWeapon();
        }
        else if (Input.GetKeyDown(Data.SwitchWeaponDown) && selectedWeapon > 0)
        {
            selectedWeapon -= 1;
            ChangeWeapon();
        }
    }
    void ChangeWeapon()
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            if (i != selectedWeapon)
            {
                weapons[i].GetComponent<WeaponScript>().DisableWeapon();
            }
            else
            {
                weapons[i].SetActive(true);
                Debug.Log(weapons[i].name);
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    [SerializeField] KeybindsData Data;
    [SerializeField] GameObject[] weapons;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(weapons[0].name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

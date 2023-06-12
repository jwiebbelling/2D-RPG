using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetKeyBinds : MonoBehaviour
{
    [SerializeField] KeybindsData CurKeyBinds;
    [SerializeField] KeybindsData DefKeyBinds;
    public void onButtonPress()
    {
        CurKeyBinds = DefKeyBinds;
    }
}

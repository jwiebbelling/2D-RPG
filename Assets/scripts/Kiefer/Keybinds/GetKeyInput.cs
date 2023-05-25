using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetKeyInput : MonoBehaviour
{
    [SerializeField] InputField input;
    [SerializeField] KeybindsData keybinds;
    public string keybind;

    public void OnEditKey()
    {
        input.Select();
        input.ActivateInputField();
    }

    public void OnKeyGet()
    {
        foreach (KeyCode keyCode in Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKey(keyCode))
            {
                keybinds.SetNewKey(keybind, keyCode);
            }
        }
        input.DeactivateInputField();
    }
}

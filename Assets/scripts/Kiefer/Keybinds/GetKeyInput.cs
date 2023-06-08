using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetKeyInput : MonoBehaviour
{
    [SerializeField] private InputField input;
    [SerializeField] private KeybindsData keybinds;
    [SerializeField] private GameObject editKey;

    private string keybind;

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

        input.text = "";
        input.DeactivateInputField();
        editKey.SetActive(false);
    }
    public void SetKeyBind(string key)
    {
        keybind = key;
    }
}

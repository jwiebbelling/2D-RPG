using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetKeyInput : MonoBehaviour
{
    [SerializeField] InputField input;

    public void OnEditKey()
    {
        input.Select();
        input.ActivateInputField();
    }

    public void OnKeyGet()
    {
        string key = input.text;

        Debug.Log(key);
    }
}

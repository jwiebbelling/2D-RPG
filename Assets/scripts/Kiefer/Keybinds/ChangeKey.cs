using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeKey : MonoBehaviour
{
    [SerializeField] Text text;
    [SerializeField] KeybindsData keybinds;
    [SerializeField] string key;

    void Update()
    {
        ChangeText(key);
    }
    
    void ChangeText(string key)
    {
        switch (key)
        {
            case "Up":
                text.text = keybinds.Up.ToString();
                break;
            case "Down":
                text.text = keybinds.Down.ToString();
                break;
            case "Left":
                text.text = keybinds.Left.ToString();
                break;
            case "Right":
                text.text = keybinds.Right.ToString();
                break;
            case "Dash":
                text.text = keybinds.Dash.ToString();
                break;
            case "Shoot":
                text.text = keybinds.Shoot.ToString();
                break;
            case "Reload":
                text.text = keybinds.Reload.ToString();
                break;
            case "Interact":
                text.text = keybinds.Interact.ToString();
                break;
            case "UsePowerUp":
                text.text = keybinds.UsePowerUp.ToString();
                break;

            default:
                break;
        }
    }

    public void OnButonPress()
    {
        //GetKeyInput
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetKeyBinds : MonoBehaviour
{
    [SerializeField] KeybindsData currentKeybinds;
    [SerializeField] KeybindsData defaultKeybinds;
    public void onButtonPress()
    {
        System.Type keybindsType = typeof(KeybindsData);
        System.Reflection.FieldInfo[] fields = keybindsType.GetFields();

        foreach (System.Reflection.FieldInfo field in fields)
        {
            // Get the name of the field
            string fieldName = field.Name;

            // Find the corresponding field in the default keybinds object
            System.Reflection.FieldInfo defaultField = keybindsType.GetField(fieldName);
            if (defaultField != null)
            {
                // Get the value from the default keybinds object and set it in the current keybinds object
                KeyCode defaultValue = (KeyCode)defaultField.GetValue(defaultKeybinds);
                field.SetValue(currentKeybinds, defaultValue);
            }
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

public class ChangeKey : MonoBehaviour
{
    [SerializeField] private KeybindsData keybinds;
    [SerializeField] private GameObject inputField;
    [SerializeField] private GameObject editKey;

    private Text text;
    private string keybind;

    private void Awake()
    {
        keybind = gameObject.name;

        text = transform.Find("Button/ButtonText").gameObject.GetComponent<Text>();
    }
    void Update()
    {
        ChangeText(keybind);
    }

    void ChangeText(string keybind)
    {
        switch (keybind)
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
            case "SwitchWeaponUp":
                text.text = keybinds.SwitchWeaponUp.ToString();
                break;
            case "SwitchWeaponDown":
                text.text = keybinds.SwitchWeaponDown.ToString();
                break;

            default:
                break;
        }
    }

    public void OnButonPress()
    {
        editKey.SetActive(true);

        inputField.GetComponent<GetKeyInput>().SetKeyBind(keybind);
        inputField.GetComponent<GetKeyInput>().OnEditKey();
    }
}

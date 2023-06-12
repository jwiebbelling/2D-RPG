using UnityEngine;

[CreateAssetMenu(menuName = "KeybindsData")]
public class KeybindsData : ScriptableObject
{
    public KeyCode Up;
    public KeyCode Left;
    public KeyCode Down;
    public KeyCode Right;
    public KeyCode Dash;

    public KeyCode Shoot;
    public KeyCode Reload;
    public KeyCode Interact;
    public KeyCode UsePowerUp;
    public KeyCode SwitchWeaponUp;
    public KeyCode SwitchWeaponDown;

    public KeyCode SetNewKey(string keybind, KeyCode key)
    {
        keybind.ToLower();
        switch (keybind)
        {
            case "Up":
                return Up = key;

            case "Left":
                return Left = key;

            case "Down":
                return Down = key;

            case "Right":
                return Right = key;

            case "Dash":
                return Dash = key;

            case "Shoot":
                return Shoot = key;

            case "Reload":
                return Reload = key;

            case "Interact":
                return Interact = key;

            case "UsePowerUp":
                return UsePowerUp = key;

            case "SwitchWeaponUp":
                return SwitchWeaponUp = key;

            case "SwitchWeaponDown":
                return SwitchWeaponDown = key;

            default:
                return KeyCode.None;
        }
    }
}

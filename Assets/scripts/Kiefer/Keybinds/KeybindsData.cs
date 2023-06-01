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
            case "up":
                return Up = key;

            case "left":
                return Left = key;

            case "down":
                return Down = key;

            case "right":
                return Right = key;

            case "dash":
                return Dash = key;

            case "shoot":
                return Shoot = key;

            case "reload":
                return Reload = key;

            case "interact":
                return Interact = key;

            case "usepowerup":
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

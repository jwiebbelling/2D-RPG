using System.Collections;
using System.Collections.Generic;
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

    public KeyCode NewKey(string key)
    {
        key.ToLower();
        switch (key)
        {
            case "up":
                return Up;

            case "left":
                return Left;

            case "down":
                return Down;

            case "right":
                return Right;

            case "dash":
                return Dash;

            case "shoot":
                return Shoot;

            case "reload":
                return Reload;

            case "interact":
                return Interact;

            case "usepowerup":
                return UsePowerUp;

            default:
                return KeyCode.None;
        }

    }
}

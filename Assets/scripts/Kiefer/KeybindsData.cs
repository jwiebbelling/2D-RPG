using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "KeybindsData")]
public class KeybindsData : ScriptableObject
{
    public KeyCode MoveW;
    public KeyCode MoveA;
    public KeyCode MoveS;
    public KeyCode MoveD;

    public KeyCode Shoot;
    public KeyCode Reload;
    public KeyCode Interact;
}

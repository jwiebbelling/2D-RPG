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

    public KeyCode Shoot;
    public KeyCode Reload;
    public KeyCode Interact;
}

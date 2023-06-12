using System.Collections;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Vector3 teleportPosition;
    public FadeEffect fadeEffect;
    //45, -1.5, 0
    public void PerformTeleport()
    {
        StartCoroutine(TeleportCoroutine());
    }

    private IEnumerator TeleportCoroutine()
    {
        yield return StartCoroutine(fadeEffect.FadeOut());

        transform.position = teleportPosition;

        yield return StartCoroutine(fadeEffect.FadeIn());
    }
}

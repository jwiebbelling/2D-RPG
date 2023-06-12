using System.Collections;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Vector3 teleportPosition;
    public FadeEffect fadeEffect;
    public void PerformTeleport()
    {
        StartCoroutine(TeleportCoroutine());
    }

    private IEnumerator TeleportCoroutine()
    {
        yield return new WaitForSeconds(2f);

        yield return StartCoroutine(fadeEffect.FadeOut());

        transform.position = teleportPosition;

        yield return StartCoroutine(fadeEffect.FadeIn());
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NPC : MonoBehaviour
{
    public GameObject objectToEnable;

    public void Interact()
    {
        Debug.Log("NPC: Hi!");
        // Enable the object for a few seconds
        objectToEnable.SetActive(true);
        StartCoroutine(DisableObjectAfterDelay(objectToEnable, 3f)); // Change the duration (3f) as needed
    }
    private IEnumerator DisableObjectAfterDelay(GameObject obj, float delay)
    {
        yield return new WaitForSeconds(delay);
        obj.SetActive(false);
    }
}

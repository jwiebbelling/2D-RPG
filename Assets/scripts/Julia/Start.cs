using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Start : MonoBehaviour
{
    [SerializeField] private GameObject settings;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Main");
    }
    public void GoToSettings()
    {
        settings.SetActive(true);
    }
}
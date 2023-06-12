using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private KeybindsData keybinds;
    [SerializeField] private GameObject menu, settings, pauseMenu;
    private bool paused = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!paused)// false == game is paused
            {
                paused = true;
                menu.SetActive(true);
                Time.timeScale = 0f;
                Debug.Log(paused);
            }
            else if (paused)// true == game is normal
            {
                paused = false;
                settings.SetActive(false);
                pauseMenu.SetActive(true);
                menu.SetActive(false);
                Time.timeScale = 1f;
                Debug.Log(paused);
            }
        }
    }
    public void Resume()
    {
        paused = false;
        menu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Settings()
    {
        settings.SetActive(true);
        pauseMenu.SetActive(false);
    }
    public void SettingsBack()
    {
        settings.SetActive(false);
        pauseMenu.SetActive(true);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}

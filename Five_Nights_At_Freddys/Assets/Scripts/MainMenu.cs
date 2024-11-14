using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject MainMenuPanel;
    public GameObject CreditsPanel;

    public void Start()
    {
        if (MainMenuPanel != null && CreditsPanel != null)
        {
            MainMenuPanel.SetActive(true);
            CreditsPanel.SetActive(false);
        }
    }
    public void PlayGame()
    {
        Debug.Log("Play Game");
        SceneManager.LoadScene("StartScene");
        Time.timeScale = 1;
    }

    public void Credits()
    {
        if (MainMenuPanel != null && CreditsPanel != null)
        {
            MainMenuPanel.SetActive(false);
            CreditsPanel.SetActive(true);
        }
    }

    public void Back()
    {
        if (MainMenuPanel != null && CreditsPanel != null)
        {
            MainMenuPanel.SetActive(true);
            CreditsPanel.SetActive(false);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

using UnityEngine;
using UnityEngine.UI;

public class ButtonESC1 : MonoBehaviour
{
    public Button mainMenuButton;
    void Start()
    {
        mainMenuButton.onClick.AddListener(() =>
        {
            Time.timeScale = 1;
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenuScene");
        });
    }
}

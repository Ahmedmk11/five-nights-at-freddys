using UnityEngine;
using UnityEngine.UI;

public class ButtonESC2 : MonoBehaviour
{
    public Button mainMenuButton;

    float timer = 0f;
    bool timeStarted = false;
    void Start()
    {
        timeStarted = true;
        mainMenuButton.onClick.AddListener(() =>
        {
            Time.timeScale = 1;
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenuScene");
        });
    }

    void Update()
    {
        if (timeStarted)
        {
            timer += Time.deltaTime;
            if (timer >= 16.5)
            {
                // choicePanel.SetActive(true);
                Time.timeScale = 0;
                timeStarted = false;
                gameOverText.text = "You have been caught by Consort Freddy!";
                UnityEngine.SceneManagement.SceneManager.LoadScene("GameOverScene");
            }
        }

    }
}

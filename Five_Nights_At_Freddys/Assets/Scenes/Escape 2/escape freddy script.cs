using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class escapefreddyscript : MonoBehaviour
{
    // Start is called before the first frame update
    public Button mainMenuButton;
    public GameObject choicePanel;

    float timer = 0f;
    bool timeStarted = false;
    void Start()
    {
        timeStarted = true;
        choicePanel.SetActive(false);
        mainMenuButton.onClick.AddListener(() =>
        {
            Time.timeScale = 1;
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenuScene");
        });
    }

    // Update is called once per frame
    void Update()
    {
        if (timeStarted)
        {
            timer += Time.deltaTime;
            if (timer >= 7.1)
            {
                // choicePanel.SetActive(true);
                Time.timeScale = 0;
                timeStarted = false;
                gameOverText.text = "You have escaped the restaurant!";
                UnityEngine.SceneManagement.SceneManager.LoadScene("GameOverScene");
            }
        }

    }
}

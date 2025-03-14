using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class battyscript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject choicePanel;
    public Button consortFreddyButton;
    public Button escapeConsortButton;
    public Button mainMenuButton;

    float timer = 0f;
    bool timeStarted = false;
    void Start()
    {
        timeStarted = true;
        choicePanel.SetActive(false);
        consortFreddyButton.onClick.AddListener(() =>
        {
            choicePanel.SetActive(false);
            Time.timeScale = 1;
            UnityEngine.SceneManagement.SceneManager.LoadScene("MeetConsortScene");
        });
        escapeConsortButton.onClick.AddListener(() =>
        {
            choicePanel.SetActive(false);
            Time.timeScale = 1;
            UnityEngine.SceneManagement.SceneManager.LoadScene("EscapeConsortScene");
        });
        mainMenuButton.onClick.AddListener(() =>
        {
            choicePanel.SetActive(false);
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
            if (timer >= 33.5)
            {
                choicePanel.SetActive(true);
                Time.timeScale = 1;
                timeStarted = false;
            }
        }

    }
}

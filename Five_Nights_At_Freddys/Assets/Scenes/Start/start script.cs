using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class startscript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject choicePanel;
    public Button foxyButton;
    public Button battyButton;
    public Button mainMenuButton;

    float timer = 0f;
    bool timeStarted = false;
    void Start()
    {
        timeStarted = true;
        choicePanel.SetActive(false);
        foxyButton.onClick.AddListener(() =>
        {
            choicePanel.SetActive(false);
            Time.timeScale = 1;
            UnityEngine.SceneManagement.SceneManager.LoadScene("MeetFoxyScene");
        });
        battyButton.onClick.AddListener(() =>
        {
            choicePanel.SetActive(false);
            Time.timeScale = 1;
            UnityEngine.SceneManagement.SceneManager.LoadScene("MeetBattyScene");
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
            if (timer >= 25) {
                choicePanel.SetActive(true);
                Time.timeScale = 1;
                timeStarted = false;
            }
        }
        
    }
}

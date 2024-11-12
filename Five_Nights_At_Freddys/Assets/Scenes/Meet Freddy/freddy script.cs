using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class freddyscript : MonoBehaviour
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
            // UnityEngine.SceneManagement.SceneManager.LoadScene("main menu");
        });
    }

    // Update is called once per frame
    void Update()
    {
        /*if (timeStarted) WIN SCREEN
        {
            timer += Time.deltaTime;
            if (timer >= 25)
            {
                choicePanel.SetActive(true);
                Time.timeScale = 0;
                timeStarted = false;
            }
        }*/

    }
}

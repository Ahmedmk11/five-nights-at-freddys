using UnityEngine;
using UnityEngine.UI;

public class ButtonESC1 : MonoBehaviour
{
    public Button mainMenuButton;
    public GameObject imageObject;
    public GameObject imageObject2;

    float timer = 0f;
    bool timeStarted = false;
    public void ShowImage()
    {
        imageObject.SetActive(true);
        imageObject2.SetActive(true);
    }
    public void HideImage()
    {
        imageObject.SetActive(false);
        imageObject2.SetActive(false);
    }
    void Start()
    {
        timeStarted = true;
        HideImage();
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
            if (timer >= 22.5)
            {
                // choicePanel.SetActive(true);
                Time.timeScale = 0;
                timeStarted = false;
                gameOverText.text = "To Be Continued..";
                UnityEngine.SceneManagement.SceneManager.LoadScene("GameOverScene");
            }
        }

    }
}

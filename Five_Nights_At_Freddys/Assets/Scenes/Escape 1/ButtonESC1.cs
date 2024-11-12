using UnityEngine;
using UnityEngine.UI;

public class ButtonESC1 : MonoBehaviour
{
    public Button mainMenuButton;
    public GameObject imageObject;
    public void ShowImage()
    {
        imageObject.SetActive(true);
    }
    public void HideImage()
    {
        imageObject.SetActive(false);
    }
    void Start()
    {
        HideImage();
        mainMenuButton.onClick.AddListener(() =>
        {
            Time.timeScale = 1;
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenuScene");
        });
    }
}

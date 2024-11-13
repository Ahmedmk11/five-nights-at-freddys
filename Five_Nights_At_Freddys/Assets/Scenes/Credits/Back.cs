using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Back : MonoBehaviour
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

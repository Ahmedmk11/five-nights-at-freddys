using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class gameOverscript : MonoBehaviour
{
    public TMP_Text gameOver;
    public Button mainMenuButton;
    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetText(gameOverText.text);
        mainMenuButton.onClick.AddListener(() =>
        {
            Time.timeScale = 1;
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenuScene");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

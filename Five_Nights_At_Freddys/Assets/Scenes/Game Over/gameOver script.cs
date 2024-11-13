using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gameOverscript : MonoBehaviour
{
    public TMP_Text gameOver;
    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetText(gameOverText.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

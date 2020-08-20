using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager GameManagerInstance;
    public GameObject GameOverCanvas;
    public Text ScoreCardText,HighScoreText;
    public int currentscore, highscore;
    private void Awake()
    { 
        if (GameManagerInstance == null)
            GameManagerInstance = this;

        GameOverCanvas.SetActive(false);
    }
    private void Start()
    {
       Time.timeScale = 1;
        if(PlayerPrefs.HasKey("highscore"))
        {
            highscore = PlayerPrefs.GetInt("highscore");
            HighScoreText.text = "High Score " + highscore.ToString();
        }
    }
    private void Update()
    {
        ScoreCardText.text = currentscore.ToString();

    }
    public void Gameover()
    {
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0;
        if (currentscore > highscore)
            PlayerPrefs.SetInt("highscore", currentscore);
    }
    public void Replay()
    {
        SceneManager.LoadScene(0);
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text healthText;
    public int score;
    public Text scoreText;

    public int totalScore;

    public GameObject gameOverObj;
    
    public static GameController instance;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        totalScore = PlayerPrefs.GetInt("score");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int value)
    {
        score += value;
        scoreText.text = score.ToString();
        
        PlayerPrefs.SetInt("score", score + totalScore);
    }
    
    public void UpdateLives(int value)
    {
        healthText.text = "x " + value.ToString();
    }

    public void GameOver()
    {
        gameOverObj.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private UIManager uiManager;
    private GameUI gameUI;
    static GameManager gameManager;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI bestScoreText;

    private int currentScore = 0;
    private int highScore = 0;
    public static GameManager Instance { get { return gameManager; } }

    public static bool isFirstLoading = true;

    public UIManager UIManager { get { return uiManager; } }
    private void Awake()
    {
        gameManager = this;
        uiManager = FindObjectOfType<UIManager>();
        Time.timeScale = 0f;

    }

    private void Start()
    {
        
        if (!isFirstLoading)
        {
            StartGame();
        }
        else
        {
            isFirstLoading = false;
        }
       
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        UpdateScoreText(currentScore);
        
    }

    public void GameOver()
    {
        
        uiManager.SetGameOver();

        bestScoreText.text = "" + highScore.ToString();
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        uiManager.SetPlayGame();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AddScore(int score)
    {
        currentScore += score;
        uiManager.ChangeScore(currentScore);
    }

    public int UpdateScoreText(int score)
    {
        currentScore = score;
        scoreText.text = "" + currentScore.ToString();

        if (currentScore > highScore)
        {
            highScore = currentScore;
            PlayerPrefs.SetInt("HighScore", highScore);
        }

        return score;

    }


}

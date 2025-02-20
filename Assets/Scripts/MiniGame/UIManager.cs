using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR;
public enum UIState
{
    Home,
    Game,
    GameOver,
    Description,
}

public class UIManager : MonoBehaviour
{
    GameManager gameManager = GameManager.Instance;
    HomeUI homeUI;
    GameUI gameUI;
    GameOverUI gameOverUI;
    DescriptionUI descriptionUI;
    private UIState currentState;

    private void Awake()
    {
        homeUI = GetComponentInChildren<HomeUI>(true);
        homeUI.Init(this);
        gameUI = GetComponentInChildren<GameUI>(true);
        gameUI.Init(this);
        gameOverUI = GetComponentInChildren<GameOverUI>(true);
        gameOverUI.Init(this);
        descriptionUI = GetComponentInChildren<DescriptionUI>(true);
        descriptionUI.Init(this);
        gameManager = GameManager.Instance;

        ChangeState(UIState.Description);
    }

    public void SetHome()
    {
        ChangeState(UIState.Home);
    }
    public void SetPlayGame()
    {
        ChangeState(UIState.Game);
    }

    public void SetGameOver()
    {
       
        ChangeState(UIState.GameOver);
    }

    public void ChangeScore(int score)
    {
        gameManager.UpdateScoreText(score);
    }

    public void ChangeState(UIState state)
    {
        currentState = state;
        homeUI.SetActive(currentState);
        gameUI.SetActive(currentState);
        gameOverUI.SetActive(currentState);
        descriptionUI.SetActive(currentState);
    }
  


}

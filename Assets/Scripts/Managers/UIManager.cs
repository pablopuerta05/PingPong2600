using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    #region Singleton

    public static UIManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    #endregion

    [Header("Screens")]
    public GameObject pauseScreen;
    public GameObject resultScreen;
    public GameObject levelUpScreen;

    public void DisableScreens()
    {
        pauseScreen.SetActive(false);
        resultScreen.SetActive(false);
        levelUpScreen.SetActive(false);
    }

    public void OnPlayButtonClicked()
    {
        GameManager.Instance.SetGameState(GameManager.GameState.Gameplay);
    }

    public void OnExitButtonClicked()
    {
        Application.Quit();
    }

    public void OnPauseButtonClicked()
    {
        GameManager.Instance.SetGameState(GameManager.GameState.Paused);
    }
}

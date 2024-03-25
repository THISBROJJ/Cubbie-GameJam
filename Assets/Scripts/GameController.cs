using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController Instance = null;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        //else if (Instance != this)
        //{
           // Destroy(this.gameObject);
        //}
        DontDestroyOnLoad(gameObject);
    }


    public void StartGame()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void Lose()
    {
        SceneManager.LoadScene("Lose");
    }

    public void Win()
    {
        SceneManager.LoadScene("Win");
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("Win");
    }
}

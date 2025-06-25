using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore, highScore;
    public Text Score, highScoreTXT;
    public GameObject GameOverScreen;
    public GameObject Pipe;

    [ContextMenu("Increase Score")]
    public void aadScore(int x)
    {
        playerScore += x;
        Score.text = playerScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //Debug.Log("Hiiiiiii");
    }
    public void returnToTitle()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        //Debug.Log("");

    }
    public void gameOver()
    {
        GameOverScreen.SetActive(true);
        highScore = PlayerPrefs.GetInt("highScore");

        if (playerScore > highScore)
        {
            highScore = playerScore;
            PlayerPrefs.SetInt("highScore", playerScore);
        }
        highScoreTXT.text = "High Score: " + PlayerPrefs.GetInt("highScore").ToString();

    }
}
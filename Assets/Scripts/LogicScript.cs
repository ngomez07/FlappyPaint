using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text score;
    public GameObject gameOverScreen;

    [ContextMenu("increaseScore")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        score.text = "Score: " + playerScore.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
    public void startGame(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}

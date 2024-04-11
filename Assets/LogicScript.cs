using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOver;
    [ContextMenu("Increase Score")]
    public void addScore(int addScore)
    {
        playerScore=playerScore+addScore;
        scoreText.text = playerScore.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
 
    }
   public void endGame()
    {
        gameOver.SetActive(true);
    }
}

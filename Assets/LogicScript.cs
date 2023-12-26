using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource dingSFX;

    // ability to run from unitiy
    [ContextMenu("Increase Score")]

    void Start(){
        dingSFX = GetComponent<AudioSource>();
    }

    public void addScore(int scoreToAdd){
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        dingSFX.Play();
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void gameOver(){
        gameOverScreen.SetActive(true);

    }


}

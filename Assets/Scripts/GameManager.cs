using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    private int score;
    public Text scoreText;

    public GameObject playButton;
    public GameObject gameOver;
    public GameObject gameReady;
    public Player player;

    public void Awake() {
        Application.targetFrameRate = 60;
        gameReady.SetActive(true);
        Pause();
    }

    public void Play() {
        
        score = 0;
        scoreText.text = score.ToString();
        
        gameReady.SetActive(false);
        playButton.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for (int i = 0; i < pipes.Length; i++) {
            Destroy(pipes[i].gameObject);
        }
    }


    public void Pause() {
        Time.timeScale = 0f;
        player.enabled = false; 
        
    }

    public void GameOver() {
        Debug.Log("Game Over!");

        gameOver.SetActive(true);
        playButton.SetActive(true);

        Pause();
    }
    public void IncreasingScrore() {
        score++;
        scoreText.text = score.ToString();
    }
}

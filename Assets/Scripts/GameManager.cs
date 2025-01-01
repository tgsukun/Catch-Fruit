using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;

    public int missedFruits = 0;
    public int maxMissedFruits = 3;
    public GameObject gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int points) 
    {
        score += points;
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    public void FruitMissed() 
    {
        missedFruits++;
        if (missedFruits >= maxMissedFruits)
        {
            GameOver();
        }
    }
    
    void GameOver()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }

    public void RestartGame() 
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

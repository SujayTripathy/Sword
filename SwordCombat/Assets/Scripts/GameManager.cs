using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int score=0;
    public int health=3;

    public float speed=100;
    public Text scoreText;
    public Text healthText;
    public Text highScore;

    public Text endScoreText;

    public Shooter spawner;
    public Canvas gameUI;
    public Canvas gameOverUI;

    public Canvas menuUI;
    void Start()
    {
        highScore.text=PlayerPrefs.GetInt("HighScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text=score.ToString();
        healthText.text=health.ToString();
        if(health<=0){
            GameOver();
        }
    }

    public void Restart(){
        score=0;
        health=3;
        Time.timeScale=1;
        spawner.speed=speed;
    }

    public void GameOver(){
        endScoreText.text=score.ToString();
        setHighscore();
        score=0;
        health=3;
        gameUI.gameObject.SetActive(false);
        gameOverUI.gameObject.SetActive(true);   
        Time.timeScale=0;    
    }

    void setHighscore(){
        if(score>PlayerPrefs.GetInt("HighScore",0)){
            PlayerPrefs.SetInt("HighScore",score);
            highScore.text=PlayerPrefs.GetInt("HighScore").ToString();
        }
    }

}

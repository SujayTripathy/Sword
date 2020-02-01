using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float score=0;
    public int health=3;

    public float speed=100;
    public GameObject scoreText;
    public GameObject healthText;

    public Shooter spawner;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text=score.ToString();
        healthText.GetComponent<Text>().text=health.ToString();
        if(health<=0){
            SceneManager.LoadScene(0);
        }
    }

    public void Restart(){
        score=0;
        health=3;
        Time.timeScale=1;
        spawner.speed=speed;
    }

}

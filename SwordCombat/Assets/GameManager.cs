using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float score;
    public GameObject scoreText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text=score.ToString();
    }
}

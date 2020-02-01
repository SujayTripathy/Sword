using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    AudioSource source;
    public int scoreValue=100;
    public bool blocked=false;
    public GameManager scoreTracker;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        source=GetComponent<AudioSource>();
        Destroy(gameObject,5);
        scoreTracker=FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision){
        if(collision.transform.tag=="Sword"){
            rb.useGravity=true;
            scoreTracker.score+=scoreValue;
            scoreValue=0;
            if(!blocked){
                source.Play();
            }
            blocked=true;
        }
    }
}

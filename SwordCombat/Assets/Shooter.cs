using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject cube;
    public float speed=70;
    float time=2f;
    float initialTime;
    // Start is called before the first frame update
    void Start()
    {
        initialTime=Time.time;
    }

    // Update is called once per frame
    void Update()
    {   

        if(Time.time-initialTime>=time){
            GameObject now=Instantiate(cube,transform.position+new Vector3(Random.Range(-10,10),0,0),transform.rotation);
            now.GetComponent<Rigidbody>().AddForce(now.transform.forward*speed,ForceMode.VelocityChange);
            now.GetComponent<Rigidbody>().AddTorque(new Vector3(Random.Range(-1,1),Random.Range(-1,1),Random.Range(-1,1)),ForceMode.VelocityChange);
            speed+=1f;
            initialTime=Time.time;
        }
    }
}

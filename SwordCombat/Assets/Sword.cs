using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public float speed=10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,0,Input.GetAxis("Mouse X"))*speed*Time.deltaTime);
        transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"),0,0*speed*Time.deltaTime),Space.World);
        
    }
}

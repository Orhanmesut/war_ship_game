using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class gemi_hareket : MonoBehaviour
{
    public float gemiRotate = 0.1f;
    public float speedMove = 100.0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            // transform.Translate(0, 0, speedMove * Time.deltaTime);
            transform.position += transform.forward * speedMove * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            // transform.Translate(0, 0, speedMove * Time.deltaTime);
            transform.position += -transform.forward * speedMove * Time.deltaTime;
        }
        


        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //this.transform.Translate(-0.1f,0,0);
            this.transform.Rotate(Vector3.up, -gemiRotate);
        }
    


    
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //this.transform.Translate(+0.1f,0,0);
            this.transform.Rotate(Vector3.up, gemiRotate);
        }
        

        // Debug.Log(Time.deltaTime);
    }

    void FixedUpdate()
    {
        Debug.Log(Time.fixedDeltaTime);
        
    }


}


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ileri_hareket : MonoBehaviour
{
    public float rigidhiz = 10f;
    public float hiz = 100f;
    public bool rigid = false;
    private Rigidbody rbody;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!rigid)
        {
            this.transform.position += transform.forward * hiz * Time.deltaTime;

        }
        
    }

    void FixedUpdate()
    {
        if  (rigid)
        {
            rbody.AddForce(transform.forward * rigidhiz * Time.fixedDeltaTime);
        }
    }
}

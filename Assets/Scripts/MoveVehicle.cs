﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVehicle : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 90f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speedY = moveSpeed * Input.GetAxis("Vertical");
        // if(Input.GetKey(KeyCode.UpArrow))
        transform.Translate(Vector3.forward * speedY * Time.deltaTime);
        // else if(Input.GetKey(KeyCode.DownArrow))
            // transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        float turnSpeedAdj = turnSpeed * Input.GetAxis("Horizontal");
        // if(Input.GetKey(KeyCode.LeftArrow))
        transform.Rotate(Vector3.up, turnSpeedAdj * Time.deltaTime);
        // else if(Input.GetKey(KeyCode.RightArrow))
            // transform.Rotate(Vector3.up,  turnSpeed * Time.deltaTime);
    }
}

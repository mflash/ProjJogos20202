﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSeno : MonoBehaviour
{
    public float speed = 1f;
    public float WaveLength = 5f;
    public float WaveAmplitude = 5f;

    public float xmax;
    private float xmin;

    // Start is called before the first frame update
    void Start()
    {
        xmin = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        Vector3 lastPos = pos;
        pos.x += speed * Time.deltaTime;
        pos.z = Mathf.Sin(pos.x * 2 * Mathf.PI/WaveLength) * WaveAmplitude/2;
        if(pos.x > xmax)
            pos.x = xmin;
        // transform.forward = pos - lastPos;
        transform.position = pos;
    }
}

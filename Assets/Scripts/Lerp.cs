﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    public float speed;
    public Transform target;

    private Vector3 start;
    private float currentTime;
    private float totalTime;

    private Transform cubo2;

    // Start is called before the first frame update
    void Start()
    {
        // cubo2 = transform.Find("Cube 2");
        ResetPos();        
    }
    
    void ResetPos()
    {
        start = transform.position;
        float distance = Vector3.Distance(start, target.position);
        currentTime = 0f;
        totalTime = distance / speed;
    }

    // Update is called once per frame
    void Update()
    {
        float current = currentTime/totalTime;
        currentTime += Time.deltaTime;

        // Ease out:
        float t = current;
        // t = Mathf.Sin(current * Mathf.PI * 0.5f);
        // Ease in:
        // t = 1 - Mathf.Cos(current * Mathf.PI * 0.5f);
        // Smoothstep (combinando os dois):
        // t = t*t * (3f - 2f*t);
        // Smootherstep (mais suave)
        t = t * t * t * (t * (t * 6 - 15) + 10);
        Vector3 newPos = Vector3.Lerp(start, target.position, t);
        transform.position = newPos;
    
        if (current >= 1f)
        {
            // Se chegar no destino, sorteia uma nova posição
            float x = Random.Range(-4.5f,4.5f);
            float z = Random.Range(-4.5f,4.5f);
            target.position = new Vector3(x,0.5f,z);
            ResetPos();
            // Troca a cor do objeto (material)
            Renderer r = GetComponent<Renderer>();
            Material mat = r.material;
            mat.color = Color.blue;
        }        
    }

    // void OnGUI()
    // {
    //     string pos = string.Format("{0}", cubo2.position);
    //     GUI.Label(new Rect(10, 30, 100, 20), pos);
    // }
}

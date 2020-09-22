using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    public Transform target;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float step = speed * Time.deltaTime;
       // Move objeto na direção do target
       transform.position = Vector3.MoveTowards(transform.position,
           target.position, step);

       if(Vector3.Distance(transform.position,target.position)<0.01f)
       {
           Vector3 novaPos;
           novaPos.y = 0.5f;
           novaPos.x = Random.Range(-4.5f,4.5f);
           novaPos.z = Random.Range(-4.5f,4.5f);
           target.position = novaPos;
       }
    }

    void OnGUI()
    {
        string dist = string.Format("{0:f4}",
            Vector3.Distance(transform.position,target.position));
        // GUI.Label(new Rect(10, 10, 100, 20), dist);
    }
}

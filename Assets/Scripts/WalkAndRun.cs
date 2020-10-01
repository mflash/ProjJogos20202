using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAndRun : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
            anim.SetBool("IsRunning", true);
        else
            anim.SetBool("IsRunning", false);
    }

    public void PrintEvent(float value)
    {
        Debug.Log("PrintEvent: " + value);
    }
}

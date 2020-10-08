using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGnomo : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float delta = Input.GetAxis("Horizontal") * speed;
        //Vector2 vel = new Vector2(delta,rb.velocity.y);
        //rb.velocity = vel;
        Vector2 forca = new Vector2(delta,0);
        rb.AddForce(forca, ForceMode2D.Impulse);
    }
}

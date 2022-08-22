using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D RB;
    float playerinput;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        move();
    }

    void move()
    {
        RB.velocity = new Vector2( 0f ,Input.GetAxis("Horizontal") * speed);
    }

}

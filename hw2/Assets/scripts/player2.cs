using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    public Rigidbody2D RB;
    float playerinput;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        RB.velocity = new Vector2(0f, Input.GetAxis("Vertical") * speed);
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_movment : MonoBehaviour
{
    Rigidbody2D RB;
    
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        RB = this.GetComponent<Rigidbody2D>();
        move();
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        
    }

    void move()
    {
        RB.velocity = new Vector2(2f, 5f );
    }
}

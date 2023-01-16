using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puddle : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public float movespeed;
    public Rigidbody2D rb;
    public Vector3 startPosition;

    private float movement;

    void Start()
    {
        movespeed = 0;
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //if(isPlayer1)
        //{
        //    movement = Input.GetAxisRaw("Vertical");
        //}
        //else
        //{
        //    movement = Input.GetAxisRaw("Vertical2");
        //}

        rb.velocity = new Vector2(rb.velocity.x, movespeed);
    }

    public void MoveLeft()
    {
        if (movespeed >= 0)
            movespeed = -speed;
    }
    public void MoveRight()
    {
        if (movespeed <= 0)
            movespeed = speed;
    }

    public void MoveStop()
    {
            movespeed = 0;
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;

    }

  
}

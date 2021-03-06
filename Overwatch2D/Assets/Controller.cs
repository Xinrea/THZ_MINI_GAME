﻿using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, 0);

        rb.AddForce(movement * speed);
        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
        }
    }
}

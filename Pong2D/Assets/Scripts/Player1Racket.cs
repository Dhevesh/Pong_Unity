using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Racket : MonoBehaviour
{
    public float movementSpeed = 250f;
    public float maxSpeed = 500f;

    Rigidbody2D rigidBody2D;
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movePlayer = new Vector2(0, moveVertical);
        rigidBody2D.velocity = movePlayer * movementSpeed;
    }
}

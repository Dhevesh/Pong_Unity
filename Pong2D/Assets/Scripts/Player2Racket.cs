using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Racket : MonoBehaviour
{
    public float movementSpeed = 250;
    public float maxMovementSpeed = 500;
    private void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical2");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, moveVertical) * movementSpeed;
    }
    
}

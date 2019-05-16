using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIRacket : MonoBehaviour
{
    public GameObject ball;
    public float movementSpeed;
    private void FixedUpdate()
    {
        if (Mathf.Abs(this.transform.position.y - ball.transform.position.y) > 50)
        {
            if (transform.position.y < ball.transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 1f) * movementSpeed;
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -1f) * movementSpeed;
            }
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        }
    }
}

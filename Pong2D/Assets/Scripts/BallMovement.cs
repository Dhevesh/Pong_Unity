﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float movementSpeed = 400;
    public float extraSpeedPerHit = 50;
    public float maxSpeed = 1000;

    int hitCounter = 0;
    void Start()
    {
        StartCoroutine(this.StartBall());
    }

    public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {
        this.hitCounter = 0;
        yield return new WaitForSeconds(2);
        if (isStartingPlayer1)
            this.MoveBall(new Vector2(-1f, 0f));
        else
            this.MoveBall(new Vector2(1f, 0f));
    }
    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;

        float speed = this.movementSpeed + this.hitCounter * this.extraSpeedPerHit;

        Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();

        rigidbody2D.velocity = direction * speed;
    }

    public void IncreaseHitCounter()
    {
        if (this.hitCounter * extraSpeedPerHit <= maxSpeed)
        {
            hitCounter++;
        }
    }

    public void PositionBall(bool isStartingPlayer1)
    {
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f,0f);
        this.hitCounter = 0;
        if (isStartingPlayer1)
        {
            this.gameObject.GetComponent<Rigidbody2D>().position = new Vector2(-42f, 0f);
            StartCoroutine(StartBall(false));
            
        }
        else
        {
            this.gameObject.GetComponent<Rigidbody2D>().position = new Vector2(42f, 0f);

            StartCoroutine(StartBall(true));
        }
        
    }

}

using System.Collections;
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
            this.MoveBall(new Vector2(-1, 0));
        else
            this.MoveBall(new Vector2(1, 0));
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

}

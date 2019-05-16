using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketReset : MonoBehaviour
{
    public GameObject player1Racket;
    public GameObject player2Racket;

    public void ResetRacket()
    {
        this.player1Racket.GetComponent<Rigidbody2D>().position = new Vector2(-600f,0f);
        this.player2Racket.GetComponent<Rigidbody2D>().position = new Vector2(600f,0f);
    }
}

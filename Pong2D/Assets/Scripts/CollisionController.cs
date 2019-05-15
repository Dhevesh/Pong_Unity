using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreController scoreController;
    public RacketReset racketReset;

    void BounceFromRacket(Collision2D c)
    {
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;

        float racketHeight = c.collider.bounds.size.y;

        float x;
        if (c.gameObject.name == "Racket_Player1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        float y = (ballPosition.y - racketPosition.y) / racketHeight;

        this.ballMovement.IncreaseHitCounter();
        this.ballMovement.MoveBall(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Racket_Player1" || collision.gameObject.name == "Racket_Player2")
        {
            this.BounceFromRacket(collision);
        }else if (collision.gameObject.name == "WallLeft")
        {
            this.scoreController.GoalPlayer2();
            this.ballMovement.PositionBall(true);
            this.racketReset.ResetRacket();
        }else if (collision.gameObject.name == "WallRight")
        {
            this.scoreController.GoalPlayer1();
            this.ballMovement.PositionBall(false);
            this.racketReset.ResetRacket();
        }
    }
}

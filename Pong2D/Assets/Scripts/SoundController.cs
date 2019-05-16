using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource wallSound;
    public AudioSource racketSound;
    public AudioSource backWallSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Racket_Player1" || collision.gameObject.name == "Racket_Player2")
        {
            this.racketSound.Play();
        }
        else if (collision.gameObject.name == "WallTop" || collision.gameObject.name == "WallBottom")
        {
            this.wallSound.Play();
        }
        else
        {
            this.backWallSound.Play();
        }
    }
}

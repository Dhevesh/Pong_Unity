using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallTriggers : MonoBehaviour
{
    public Text playerScore;
    public int score = 0;
    private void OnTriggerEnter(Collider other)
    {
            score++;
            playerScore.text = score.ToString();
    }

}

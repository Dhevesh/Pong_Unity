using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateWinningPlayer : MonoBehaviour
{
    public Text winningPlayer;
    public void UpdateWinner(string winningPlayer)
    {
        this.winningPlayer.text = winningPlayer;
    }
}

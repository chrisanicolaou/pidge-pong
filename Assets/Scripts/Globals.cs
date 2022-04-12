using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Globals 
{
    public static int playerOneScore = 0;
    public static int playerTwoScore = 0;

    public static string winner = "";

    public static bool isMultiplayer;
    
    public static void CheckWinner()
    {
        if (playerOneScore == 7) {
            winner = "Left Pong Wins!";
        }
        if (playerTwoScore == 7) {
            winner = "Right Pong Wins!";
        }
    }
}
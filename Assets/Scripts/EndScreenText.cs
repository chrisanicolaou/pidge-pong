using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreenText : MonoBehaviour
{
    private TextMeshProUGUI winnerText;
    public AudioSource andyWinSFX;
    public AudioSource snuglyWinSFX;
    void Start()
    {
        winnerText = GetComponent<TextMeshProUGUI>();
        winnerText.text = Globals.winner + " Wins!";
        switch (Globals.winner)
        {
            case "Andy":
                andyWinSFX.Play();
                break;
        }
    }
}

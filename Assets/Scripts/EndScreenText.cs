using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreenText : MonoBehaviour
{
    private TextMeshProUGUI winnerText;
    public AudioSource andyWinSFX;
    public AudioSource snuglyWinSFX;

    public AudioSource music;
    private bool playMusic = true;
    void Start()
    {
        winnerText = GetComponent<TextMeshProUGUI>();
        winnerText.text = Globals.winner + " Wins!";

        switch (Globals.winner)
        {
            case "Andy":
                andyWinSFX.Play();
                break;
            
            case "Snugly":
                snuglyWinSFX.Play();
                break;
        }
    }

    void Update()
    {
        if (!andyWinSFX.isPlaying && !snuglyWinSFX.isPlaying && playMusic) {
            music.Play();
            playMusic = false;
        }
    }
}

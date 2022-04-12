using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreenText : MonoBehaviour
{
    private TextMeshProUGUI winnerText;
    void Start()
    {
        winnerText = GetComponent<TextMeshProUGUI>();
        winnerText.text = Globals.winner;
    }
}

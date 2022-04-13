using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GeneratePongsController : MonoBehaviour
{
    public GameObject leftPong;
    public GameObject rightPong;
    public GameObject enemyPong;
    public TextMeshProUGUI enemyText;
    
    void Awake()
    {
        Instantiate(leftPong, new Vector3(-8.13f, 0, 0), Quaternion.identity);
        if (Globals.isMultiplayer) {
            Instantiate(rightPong, new Vector3(8.13f, 0, 0), Quaternion.identity);
        }
        if (!Globals.isMultiplayer) {
            Instantiate(enemyPong, new Vector3(8.13f, 0, 0), Quaternion.identity);
            enemyText.enabled = false;
        }
    }
}

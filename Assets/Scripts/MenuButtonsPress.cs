using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButtonsPress : MonoBehaviour
{
    public Button onePlayerButton, twoPlayerButton, exitGameButton;
    void Start() 
    {   
        onePlayerButton.onClick.AddListener(delegate {TaskWithParameters("onePlayer"); });
        twoPlayerButton.onClick.AddListener(delegate {TaskWithParameters("twoPlayer"); });
        exitGameButton.onClick.AddListener(delegate {TaskWithParameters("exitGame"); });
    }

    void TaskWithParameters(string button)
    {
        switch(button)
        {
            case "onePlayer":
                Globals.isMultiplayer = false;
                Globals.ResetGlobals();
                SceneManager.LoadScene("Main_Game");
                break;

            case "twoPlayer":
                Globals.isMultiplayer = true;
                Globals.ResetGlobals();
                SceneManager.LoadScene("Main_Game");
                break;
            
            case "exitGame":
                Application.Quit();
                break;
        }
    }
}

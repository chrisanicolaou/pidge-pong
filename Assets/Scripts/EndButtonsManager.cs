using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndButtonsManager : MonoBehaviour
{
    public Button playAgainButton, mainMenuButton, exitGameButton;
    void Start() 
    {   
        playAgainButton.onClick.AddListener(delegate {TaskWithParameters("playAgain"); });
        mainMenuButton.onClick.AddListener(delegate {TaskWithParameters("mainMenu"); });
        exitGameButton.onClick.AddListener(delegate {TaskWithParameters("exitGame"); });
    }

    void TaskWithParameters(string button)
    {
        switch(button)
        {
            case "playAgain":
                Globals.ResetGlobals();
                SceneManager.LoadScene("Main_Game");
                break;

            case "mainMenu":
                SceneManager.LoadScene("Title_Scene");
                break;
            
            case "exitGame":
                Application.Quit();
                break;
        }
    }
}


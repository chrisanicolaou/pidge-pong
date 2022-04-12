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
        //FINISH THIS:
        
        // PlayGameButton.onClick.AddListener(delegate {TaskWithParameters("PlayGame"); });
        // ExitGameButton.onClick.AddListener(delegate {TaskWithParameters("ExitGame"); });
    }

    void TaskWithParameters(string button)
    {
        switch(button)
        {
            case "PlayGame":
                SceneManager.LoadScene("Main_Game");
                break;

            case "ExitGame":
                Application.Quit();
                break;
        }
    }
}

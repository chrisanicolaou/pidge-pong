using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseForHorns : MonoBehaviour
{
    public AudioSource horns;
    void Start()
    {
        horns.Play();
        Time.timeScale = 0f;
    }
    
    void Update() //Put 'resume' functionality in Update - although it is worse for performance, the game is small. Code that is easier to refactor > performance
    {
        if (!horns.isPlaying) {
            Time.timeScale = 1f;
            Destroy(this);
        }
    }
}

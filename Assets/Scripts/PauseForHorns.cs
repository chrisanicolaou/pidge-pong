using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseForHorns : MonoBehaviour
{
    public AudioSource horns;
    public AudioSource music;
    void Start()
    {
        Time.timeScale = 0f;
    }
    
    void Update()
    {
        if (!horns.isPlaying) {
            Time.timeScale = 1f;
            music.Play();
            Destroy(this.gameObject);
        }
    }
}

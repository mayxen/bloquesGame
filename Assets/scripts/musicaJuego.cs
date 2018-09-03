using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicaJuego : MonoBehaviour {


    public AudioSource audio;
    public AudioClip completo;
    public AudioClip gameover;
	
    public void gameOver()
    {
        reproduce(gameover);
    }
    public void completado()
    {
        reproduce(completo);
    }

    void reproduce(AudioClip son)
    {
        audio.clip = son;
        audio.loop = false;
        audio.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPelota : MonoBehaviour {


    public AudioSource bloque;
    public AudioSource otracosa;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bloque"))
        {
            bloque.Play();
        }
        else
        {
            otracosa.Play();
        }
    }
}

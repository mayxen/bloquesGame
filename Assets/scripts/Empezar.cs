using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Empezar : MonoBehaviour {

    public interBtn empezar;
	// Update is called once per frame
	void Update () {
        if(empezar.pulsado|| Input.GetButtonDown("Fire1"))
        {
            Vida.vidas = 3;
            Puntuacion.puntuacion = 0;
            SceneManager.LoadScene("nivel1");
        }
	}
}

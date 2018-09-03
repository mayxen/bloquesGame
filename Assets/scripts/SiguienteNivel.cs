using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SiguienteNivel : MonoBehaviour {


    public string nivelACargar;
    public float retardo;
	
    public void activarCarga()
    {
        Invoke("cargarNivel",retardo);
    }

    void cargarNivel()
    {
        if (!isLastLevel()) Vida.vidas++;
        SceneManager.LoadScene(nivelACargar);
    }

    public bool isLastLevel()
    {
        return nivelACargar == "portada";
    }
}

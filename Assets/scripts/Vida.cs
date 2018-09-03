using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour {

    public static int vidas=3;
    public Text tVidas;
    public GameObject GOver;
    public SiguienteNivel nivel;
    public MovPelota pel;
    public MovBarra barr;
    public musicaJuego musica;

	// Use this for initialization
	void Start () {
        actVidas();
	}
	
    void actVidas()
    {
        tVidas.text = "Vidas " + vidas;
    }
	public void pVida()
    {
        if (vidas <= 0) return;
        vidas--;
        actVidas();
        if (vidas == 0)
        {
            GOver.SetActive(true);
            pel.pararMov();
            barr.enabled = false;
            musica.gameOver();
            nivel.nivelACargar = "portada";
            nivel.activarCarga();
        }else
        {
            barr.reset();
            pel.reset();

        }


    }
}

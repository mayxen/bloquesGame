using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour {
    public static int puntuacion = 0;

    public GameObject finJuego;
    public GameObject finNivel;
    public SiguienteNivel nextLvl;
    public MovPelota pelota;
    public MovBarra  barra;
    public Transform numBloq;
    public Text text;
    public musicaJuego musica;

    // Use this for initialization
    void Start () {
        act();
	} 
	void act()
    {
        text.text = "Puntos " + puntuacion;
    }
	
	public void punto () {
        puntuacion++;
        act();

        if (numBloq.childCount<=0)
        {
            pelota.pararMov();
            barra.enabled = false;
            if (nextLvl.isLastLevel())
            {
                finJuego.SetActive(true);
            }
            else
            {
                finNivel.SetActive(true);
            }
            
            nextLvl.activarCarga();
            musica.completado();
        }
	}
}

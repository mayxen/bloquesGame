using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBarra : MonoBehaviour {

    public float velocidad =15f;
    Vector3 posInicial;
    public interBtn btnIz;
    public interBtn btnDer;

	// Use this for initialization
	public void Start () {
        posInicial = transform.position;
	}

    public void reset()
    {
        transform.position = posInicial;
    }

    // Update is called once per frame
    void Update () {
        //if (btnDer.pulsado) direccion = 1; es lo que hace el de abajo
        //else if (btnIz.pulsado) direccion = -1;

        float direccion = btnIz.pulsado ? -1 : (btnDer.pulsado ? 1 : Input.GetAxisRaw("Horizontal"));
        float posX = transform.position.x + (direccion*velocidad * Time.deltaTime); //delta time es para que se haga por fotograma y no por segundo
        transform.position = new Vector3(Mathf.Clamp(posX,-7,7),transform.position.y,0);
	}
}

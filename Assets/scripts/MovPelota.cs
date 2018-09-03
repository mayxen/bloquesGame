using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPelota : MonoBehaviour {

    Rigidbody rig;
    public float velocidad = 600f;
    bool enJuego; //se inicializa a false por eso no lo pongo
    Vector3 posInicial;
    public Transform barra;
    public interBtn empezar;
    

    private void Awake()
    {
        rig = GetComponent<Rigidbody>();//cogo la referencia del rigidbody de la pelota, pero sin poner nada publico, pero me aseguro que sea el de la pelota y no otro
    }

    public void Start()
    {
        posInicial = transform.position;
    }

    public void pararMov()
    {
        rig.isKinematic = true;
        rig.velocity = Vector3.zero;
    }
    public void reset()
    {
        transform.SetParent(barra);
        transform.position = posInicial;
        enJuego = false;
        rig.isKinematic = true;
        rig.velocity =Vector3.zero;
    }

    // Update is called once per frame
    void Update () {
        if (!enJuego && (empezar.pulsado|| Input.GetButtonDown("Fire1")))
        {
            enJuego = true;
            transform.SetParent(null);
            rig.isKinematic = false;
            rig.AddForce(new Vector3(velocidad,velocidad,0));
        }
	}
}

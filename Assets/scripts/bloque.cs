using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloque : MonoBehaviour {

    public GameObject efecto;
    public Puntuacion pto;
    //este es para cuando tines el trigger desactivado sino sería on trigger enter
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(efecto,transform.position,Quaternion.identity);
        Destroy(gameObject);
        transform.SetParent(null);//como el destroy no se hace efectivo hasta el final, nunca se llegaría a ejecutar el final de partida, por ello lo quitamos de hijo y listo
        pto.punto();
        
    }
}

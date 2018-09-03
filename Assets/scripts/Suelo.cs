using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour {

    public Vida vida;

    private void OnTriggerEnter(Collider other)
    {
        vida.pVida();
    }
}

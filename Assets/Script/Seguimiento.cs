using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguimiento : MonoBehaviour
{
    public GameObject Jugador;

    // Update is called once per frame
    void Update()
    {
        transform.position = Jugador.transform.position + new Vector3(-0.0399999991f, 0.280000001f, 1.4899998f);
    }
}

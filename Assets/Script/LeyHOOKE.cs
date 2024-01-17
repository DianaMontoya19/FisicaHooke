using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeyHOOKE : MonoBehaviour
{
    public float constanteElastica = 10f;
    public float amortiguamiento = 0.5f;

    private float posicionObjeto;
    private float velocidadObjeto;
 

    // Update is called once per frame
    void Update()
    {
        simularMovimiento();
    }
    void simularMovimiento()
    {
        float fuerzaElastica = -constanteElastica * posicionObjeto;
        
        // aplicar amortiguamiento

        fuerzaElastica -=amortiguamiento * velocidadObjeto;

        float aceleracion = fuerzaElastica;
        
        velocidadObjeto += aceleracion*Time.deltaTime;
        posicionObjeto += velocidadObjeto * Time.deltaTime;

        transform.position = new Vector3(transform.position.x, posicionObjeto, transform.position.z);



    }
}


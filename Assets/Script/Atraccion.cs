using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atraccion : MonoBehaviour
{
    public float attractionForce = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // encontar objetos en la escena
        GameObject[] magneticObject = GameObject.FindGameObjectsWithTag("MagneticObject");

        foreach(GameObject magnetic in magneticObject) { 
        if(magnetic != gameObject) // no atraerse el mismo
            {
                Rigidbody rb = magnetic.GetComponent<Rigidbody>();
                if(rb != null)
                {
                    Vector3 direction = transform.position-magnetic.transform.position;

                    //fuerza de atraccion
                    float distance = direction.magnitude;
                    float ForceMagnute = attractionForce / Mathf.Pow(distance,2);
                    //Aplicar fuerza al objeto atraido

                    rb.AddForce(direction.normalized*ForceMagnute);
                }
            }
        }
    }
}

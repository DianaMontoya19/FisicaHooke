using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour

{
    public float fuerzaSalto = 100f;
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody rb = GetComponent<Rigidbody>();

            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
        }
  
    }
}

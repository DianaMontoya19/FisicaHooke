using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rebote : MonoBehaviour
{
   private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Pendulo"))
        {
            rb.useGravity=false;
            rb.AddForce(Vector3.left * 10, ForceMode.Force);
        }
    }
}

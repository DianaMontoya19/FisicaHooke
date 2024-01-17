using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float velocidad = 5f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();



    }
    void Update()
    {
        float movimientoHor = Input.GetAxisRaw("Horizontal");
        float xSpeed = movimientoHor * velocidad;
        float movimientoVer = Input.GetAxisRaw("Vertical");
        float zSpeed = movimientoVer * velocidad;

        Vector3 movimiento = new Vector3(xSpeed, rb.velocity.y, zSpeed);


        rb.velocity = movimiento;
      


    }

}

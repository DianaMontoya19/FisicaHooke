using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulo2 : MonoBehaviour
{
    public float length = 5f; // Longitud de la cuerda
    public float gravity = 9.8f; // Aceleraci�n debida a la gravedad
                                 // public float damping = 0.99f; // Factor de amortiguamiento para simular resistencia del aire
                                 // Estado del p�ndulo
    private float angle = 45f; // �ngulo inicial del p�ndulo
    private float angularVelocity = 0f; // Velocidad angular inicial

    //{
    //  if(randomStart)
    //    {
    //        random = Random.Range(0,1); // inicializar el valor aleatoria random, siempre y cuando el random start sea verdadero
    //    }
    //}

    // Update is called once per frame
    //void Update()
    //{
    //    float angle = limit * Mathf.Sin(Time.time + random * speed); // calcula el angulo en funcion del tiempo, en segundos,

    //    transform.localRotation = Quaternion.Euler(0, 0, angle);// quaternion aplica la rotacion al objeto utilizando el angulo
    //}

    void Update()
    {
        // Calcular la aceleraci�n angular usando la ecuaci�n del p�ndulo simple
        float angularAcceleration = (-gravity / length) * Mathf.Sin(angle);
        // Actualizar la velocidad angular y el �ngulo utilizando el m�todo de Verlet
        angularVelocity += angularAcceleration * Time.deltaTime;
        angle += angularVelocity * Time.deltaTime;
        // Aplicar posici�n y rotaci�n al objeto del p�ndulo
        // Vector3 newPosition = new Vector3(length * Mathf.Sin(angle), -length * Mathf.Cos(angle), 0f);
        //  transform.position = newPosition;
        transform.rotation = Quaternion.Euler( angle * Mathf.Rad2Deg, 0f,0f);
    }
}

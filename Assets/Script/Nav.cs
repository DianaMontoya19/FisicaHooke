using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Nav : MonoBehaviour
{
    public Transform Objetivo;
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = Objetivo.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

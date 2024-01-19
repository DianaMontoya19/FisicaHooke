using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Nav : MonoBehaviour
{
    //public Transform Objetivo;
    //void Start()
    //{
    //    NavMeshAgent agent = GetComponent<NavMeshAgent>();
    //    agent.destination = Objetivo.position;
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}

    private NavMeshAgent agent;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
             RaycastHit hit;
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                agent.destination=hit.point;
            }
        }
    }
}

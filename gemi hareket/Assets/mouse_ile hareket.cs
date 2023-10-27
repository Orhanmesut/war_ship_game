using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement:MonoBehaviour{

    public Camera camera;

    private RaycastHit hit;

    private NavMeshAgent agent;

    private string groundTag = "Ground";

    void Start()
    {
        agent=GetComponent<NavMeshAgent>();
    }


    void update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray =camera.ScreenPointToRay(Input.mousePosition);
            
            if(Physics.Raycast(ray,out hit,Mathf.Infinity))
            {
                agent.SetDestination(hit.point);
            }
        }
    }

}
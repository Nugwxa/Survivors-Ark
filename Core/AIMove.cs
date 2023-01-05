using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMove : MonoBehaviour
{

    private NavMeshAgent theAgent;
    public Transform target; //Player's location

	void Start () {
        theAgent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        theAgent.SetDestination(target.position); //Move to player's location.
	}
}

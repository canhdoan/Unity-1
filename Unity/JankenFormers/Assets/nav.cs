using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class nav : MonoBehaviour {


    public GameObject obj;
    private NavMeshAgent agent;
	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
		
	}
	
	// Update is called once per frame
	void Update () {
        agent.SetDestination(obj.transform.position);
		
	}
}

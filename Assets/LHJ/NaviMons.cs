using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NaviMons : MonoBehaviour {

    NavMeshAgent nav;
    Collider target;

    void Start ()
    {
        nav = transform.parent.GetComponent<NavMeshAgent>();
	}
	
	void Update ()
    {
        if(target!=null)
        nav.destination = target.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        target = other;
    }
}

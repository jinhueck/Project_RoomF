using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    public Joystick stick;
	// Use this for initialization
	void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = new Vector3(stick.Horizontal, 0, stick.Vertical);

        GetComponent<Rigidbody>().velocity = pos * 10f;
        
    }
}

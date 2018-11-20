using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Real_Move_Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 vec = (transform.forward * h * -1 + transform.right * v ) * Time.deltaTime;
        transform.Translate(vec);
	}
}

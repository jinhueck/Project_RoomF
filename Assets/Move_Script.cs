using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Script : MonoBehaviour {
    public Vector3 pos;
    public Vector3 nowPos;
	// Use this for initialization
	void Start () {
        nowPos = transform.position - pos;

    }
	
	// Update is called once per frame
	void Update () {
        Vector3 vec = this.transform.position - pos;
        Debug.Log("vec : " + vec);
        //transform.GetChild(0).transform.position = transform.position + vec.normalized * 0.2f;
        transform.GetChild(0).transform.position = transform.position + new Vector3(0,-0.1f,0) + vec.normalized * 0.2f;
    }
}

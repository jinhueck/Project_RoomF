using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {

    public Transform Player;
    Vector3 Pos;

	// Use this for initialization
	void Start () {
        Pos = transform.position - Player.position;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = Player.transform.position + Pos;
	}
}

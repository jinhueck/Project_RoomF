using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Rotation_Script : MonoBehaviour {
    public Joystick stick;
    public GameObject obj;
    Vector3 pos;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        pos = new Vector3(stick.Horizontal, 0, stick.Vertical);
        transform.LookAt(transform.position - pos.normalized);

        
    }
    public void Shoot()
    {
        Debug.Log("QWEQWE");
        GameObject Obj = Instantiate(obj, transform);
        Obj.GetComponent<Rigidbody>().velocity = -1 * pos * 20f;
    }

}

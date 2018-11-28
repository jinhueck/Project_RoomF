using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_Script : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            other.transform.GetChild(0).GetComponent<Nav_Mons>().Hitted();
            Destroy(this.gameObject);
        }
        
    }
}

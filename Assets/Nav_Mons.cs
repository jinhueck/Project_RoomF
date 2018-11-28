using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Nav_Mons : MonoBehaviour {

    NavMeshAgent nav;
    public GameObject target;

    private void Awake()
    {
        nav = transform.parent.GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (target != null)
            nav.destination = target.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
            target = other.gameObject;
    }
    Coroutine cor;
    public void Hitted()
    {
        if (cor != null)
            StopCoroutine(cor);
        cor = StartCoroutine(Stop());
    }

    IEnumerator Stop()
    {
        transform.parent.GetComponent<Rigidbody>().isKinematic = true;
        nav.isStopped = true;
        yield return new WaitForSeconds(3f);
        transform.parent.GetComponent<Rigidbody>().isKinematic = false;
        nav.isStopped = false;
    }
}

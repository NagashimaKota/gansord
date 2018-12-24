using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bllet : MonoBehaviour {

    public GameObject ballet;

    void Start ()
    {
		
	}

    
    void Update ()
    {
		
	}

    public void Ban()
    {
        GameObject a = Instantiate(ballet);
        a.AddComponent<Rigidbody>();
        a.GetComponent<Rigidbody>().AddForce(Vector3.forward);
    }
}

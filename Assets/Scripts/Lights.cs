using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    public GameObject light;

	void Start ()
    {
        light = GameObject.Find("Point Light");
	}
	
	void Update ()
    {
        
		
	}

    void OnTriggerEnter(Collider RightHandAnchor)
    {
        Instantiate(light);
    }

    void OnTriggerLeave(Collider RightHandAnchor)
    {
        Destroy(light);
    }
}

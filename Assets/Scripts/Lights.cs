using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    public GameObject light;

	void Start ()
    {
        light = GameObject.Find("Point Light");
        light.SetActive(false);
	}
	
	void Update ()
    {
        
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lamp"))
        {
            light.SetActive(true);
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Lamp"))
        {
            light.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eating : MonoBehaviour {

	void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Food")
        {
            Destroy(collider.gameObject);
        }
    }
}

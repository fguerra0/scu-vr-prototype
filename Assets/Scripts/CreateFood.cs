﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFood : MonoBehaviour
{
    public GameObject food;
    public GameObject hand1;
    public GameObject hand2;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == hand1.name || other.gameObject.name == hand2.name)
        {      
            Instantiate(food, transform.position+(transform.forward*2), transform.rotation);
        }
    }
}

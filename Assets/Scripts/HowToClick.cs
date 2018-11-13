using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HowToClick : MonoBehaviour {

    public GameObject howto;
    public GameObject begin;
    public GameObject back;
    public Text instructions;
    public RawImage logo;
    
	public void Start ()
    {
        howto.SetActive(true);
        begin.SetActive(true);
        back.SetActive(false);
        logo.enabled = true;
        instructions.enabled = false;
	}
	
	public void clicking()
    {
        howto.SetActive(false);
        begin.SetActive(false);
        back.SetActive(true);
        logo.enabled = false;
        instructions.enabled = true;
    }
}

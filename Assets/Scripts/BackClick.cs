using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackClick : MonoBehaviour {

    public GameObject howto;
    public GameObject begin;
    public GameObject back;
    public Text instructions;
    public RawImage logo;

    public void clicking()
    {
        howto.SetActive(true);
        begin.SetActive(true);
        back.SetActive(false);
        logo.enabled = true;
        instructions.enabled = false;
    }
}

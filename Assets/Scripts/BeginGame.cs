using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeginGame : MonoBehaviour {

    public Canvas menu;
    public GameObject playerController;

    void OnEnable()
    {
        playerController = GameObject.Find("OVRPlayerController");
        playerController.GetComponent<OVRPlayerController>().enabled = false;
    }

    public void gameStart()
    {
        menu.enabled = false;
        playerController = GameObject.Find("OVRPlayerController");
        playerController.GetComponent<OVRPlayerController>().enabled = true;
    }

}

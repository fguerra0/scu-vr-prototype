using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeginGame : MonoBehaviour {

    public Canvas menu;
    public GameObject playerController;

    public void Start()
    {
        OVRPlayerController help = playerController.GetComponent<OVRPlayerController>();
        help.enabled = false;
    }

    public void gameStart()
    {
        menu.enabled = false;
        OVRPlayerController ovrpc = playerController.GetComponent<OVRPlayerController>();
        ovrpc.enabled = true;
    }

}

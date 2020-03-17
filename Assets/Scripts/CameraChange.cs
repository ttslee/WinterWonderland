using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {

    public GameObject tpCam;
    public GameObject fpCam;

    //public Camera tpCam;
    //public Camera fpCam;

	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            ShowFirstPersonView();
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ShowThirdPersonView();
        }
    }

    public void ShowFirstPersonView()
    {
        fpCam.SetActive(true);
        tpCam.SetActive(false);
    }

    public void ShowThirdPersonView()
    {
        fpCam.SetActive(false);
        tpCam.SetActive(true);
    }
}

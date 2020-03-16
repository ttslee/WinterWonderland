using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {

    public Camera tpCam;
    public Camera fpCam;

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
        fpCam.enabled = true;
        tpCam.enabled = false;
    }

    public void ShowThirdPersonView()
    {
        fpCam.enabled = false;
        tpCam.enabled = true;
    }
}

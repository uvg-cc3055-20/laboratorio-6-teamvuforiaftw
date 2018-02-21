using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARCamera : MonoBehaviour 
{
    private void Start()
    {
        CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }
}

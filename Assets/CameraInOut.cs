using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInOut : MonoBehaviour
{
    public bool Visible;
    private Camera mainCamera;
    void Start()
    {
        mainCamera = Camera.main;    
    }

    void Update()
    {
    }

    private void OnBecameVisible()
    {
        Visible = true;
    }

    private void OnBecameInvisible()
    {
        Visible = false;    
    }

}

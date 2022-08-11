using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceTheCamera : MonoBehaviour
{
    private Transform cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 cameraForward = transform.position + cam.rotation * Vector3.forward;
        Vector3 cameraUp = cam.rotation * Vector3.up;
        transform.LookAt(cameraForward,cameraUp);
    }
}

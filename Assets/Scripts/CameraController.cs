using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Vector3 lastMousePosition;
    Vector3 angle = new Vector3(0, 0, 0);
    public float mouseSensitivity;

    void Start()
    {
        angle = this.transform.localEulerAngles;
        lastMousePosition = Input.mousePosition;
    }

    void Update()
    {
        angle.y += (Input.mousePosition.x - lastMousePosition.x)*mouseSensitivity;
        angle.x -= (Input.mousePosition.y - lastMousePosition.y)*mouseSensitivity;
        this.gameObject.transform.localEulerAngles = angle;
        lastMousePosition = Input.mousePosition;
    }
}

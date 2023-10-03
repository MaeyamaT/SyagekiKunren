using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CameraController : MonoBehaviour
{
    public GameController gc;
    Vector3 angle;
    Vector3 primaryAngle;
    float yLimit = 40f;
    float xLimit = 25f;
    public float sensitivity = 1;
    AudioSource audioSource;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        angle = this.gameObject.transform.localEulerAngles;
        primaryAngle = this.gameObject.transform.localEulerAngles;
    }
    void Update()
    {
        angle.y += Input.GetAxis("Mouse X") * sensitivity;

        if (angle.y <= primaryAngle.y - yLimit)
        {
            angle.y = primaryAngle.y - yLimit;
        }
        if (angle.y >= primaryAngle.y + yLimit)
        {
            angle.y = primaryAngle.y + yLimit;
        }

        angle.x -= Input.GetAxis("Mouse Y") * sensitivity;

        if (angle.x <= primaryAngle.x - xLimit)
        {
            angle.x = primaryAngle.x - xLimit;
        }
        if (angle.x >= primaryAngle.x + xLimit)
        {
            angle.x = primaryAngle.x + xLimit;
        }

        this.gameObject.transform.localEulerAngles = angle;

        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();;
            Ray ray = Camera.main.ViewportPointToRay(new Vector2(0.5f, 0.5f));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100f))
            {
                Destroy(hit.collider.gameObject);
                gc.score++;
                Debug.Log(gc.score);
            }
        }
    }
}

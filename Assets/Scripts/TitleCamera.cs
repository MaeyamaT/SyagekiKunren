using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleCamera : MonoBehaviour
{
    bool leftMove = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.localEulerAngles.y < 10 && leftMove == false)
        {
            transform.Rotate(new Vector3(0f, 0.01f, 0f));
        }
        else
        {
            leftMove = true;
        }

        if (gameObject.transform.localEulerAngles.y > -10 && leftMove == true)
        {
            transform.Rotate(new Vector3(0f, -0.01f, 0f));
        }
        else
        {
            leftMove = false;
        }


    }
}

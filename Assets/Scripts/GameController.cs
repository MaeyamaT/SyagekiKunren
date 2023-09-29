using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float totalTime=60;
    int time;
    void Start()
    {
        
    }

    void Update()
    {
        totalTime-=Time.deltaTime;
        time=(int)totalTime;
        if (time < 0) time = 0;
    }
}

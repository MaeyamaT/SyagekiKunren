using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameController gc;
    public Text timerText;
    public int time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time=(int)gc.totalTime;
        timerText.text=time.ToString();
    }
}

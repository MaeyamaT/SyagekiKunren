using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{
    public GameController gameCon;
    public CameraController cameraCon;
    public TargetGenerator targetGen;
    public GameController gc;
    public GameObject startText;
    float startTime = 3.0f;
    bool flag = false;
    public GameObject timer;
    public GameObject stt;
    public GameObject cross;
    public Text startTimer;
    // Start is called before the first frame update
    void Start()
    {
        Ready();
    }
    void Ready()
    {
        cameraCon.GetComponent<CameraController>().enabled = false;
        gameCon.GetComponent<GameController>().enabled = false;
        targetGen.GetComponent<TargetGenerator>().enabled = false;
    }
    void GameStart()
    {
        timer.SetActive(true);
        stt.SetActive(false);
        cross.SetActive(true);
        cameraCon.GetComponent<CameraController>().enabled = true;
        gameCon.GetComponent<GameController>().enabled = true;
        targetGen.GetComponent<TargetGenerator>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            startText.SetActive(false);
            stt.SetActive(true);
            flag = true;
            Invoke("GameStart", startTime);
        }
        if (flag)
        {
            startTime -= Time.deltaTime;
            if (startTime < 0)
            {
                startTime = 0;
            }
            startTimer.text = "開始まで" + startTime.ToString("f1");
        }
    }
}

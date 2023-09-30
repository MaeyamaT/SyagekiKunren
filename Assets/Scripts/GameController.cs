using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public CameraController cc;
    float totalTime=10;
    public GameObject resultText;
    public Text scoreText;

    void Start()
    {
        resultText.SetActive(false);
    }

    void Update()
    {
        scoreText.text = "SCORE:"+cc.score.ToString();
        totalTime-=Time.deltaTime;
        if(totalTime < 0)
        {
            totalTime = 0;
        }
        if(totalTime == 0)
        {
            resultText.SetActive(true);
            cc.GetComponent<CameraController>().enabled = false;
            Invoke("ChangeScene", 5.0f);
        }
    }
    void ChangeScene()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene("Score");
    }
}

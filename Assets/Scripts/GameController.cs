using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public CameraController cc;
    public GameState gs;
    public float totalTime = 60.0f;
    public GameObject resultText;
    public Text scoreText;
    public int score = 0;
    public GameObject option;

    void Start()
    {

    }

    void Update()
    {
        scoreText.text = "SCORE:" + score.ToString();
        if (option.activeSelf)
        {
        }
        else
        {
            totalTime -= Time.deltaTime;
            if (totalTime < 0)
            {
                totalTime = 0;
            }
            if (totalTime == 0)
            {
                resultText.SetActive(true);
                gs.cross.SetActive(false);
                cc.GetComponent<CameraController>().enabled = false;
                Invoke("ChangeScene", 5.0f);
            }
        }
    }
    void ChangeScene()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene("Score");
    }
}

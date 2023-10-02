using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChangeScore : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Score");
    }
}

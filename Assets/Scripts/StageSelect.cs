using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelect : MonoBehaviour
{
    public GameObject[] stages;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(stages[Random.Range(0,stages.Length)],new Vector3(0,0,0),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

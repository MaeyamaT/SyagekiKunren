using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGenerator : MonoBehaviour
{
    public GameObject target;
    void Start()
    {

    }

    void Update()
    {
        GameObject targetObj = GameObject.Find(target.name);
        if (targetObj == null)
        {
            float x = Random.Range(-8.5f, 8.5f);
            float y = Random.Range(0.5f, 7.5f);
            float z = Random.Range(2f, 8f);
            GameObject newTargetObj = Instantiate(target, new Vector3(x, y, z), target.transform.rotation);
            newTargetObj.name = target.name;
        }

    }
    
}

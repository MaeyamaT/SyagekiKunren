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
            float x = Random.Range(-7f, 7f);
            float y = Random.Range(-4f, 4f);
            float z = Random.Range(-1f, 5f);
            GameObject newTargetObj = Instantiate(target, new Vector3(x, y, z), target.transform.rotation);
            newTargetObj.name = target.name;
        }

    }
}

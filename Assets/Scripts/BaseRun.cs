using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRun : MonoBehaviour
{
    //public GameObject Base;
    public float speedBase = 1f;
    public Vector3 startPositionBase = new Vector3(7.56f, -4f, 0);
    public Vector3 finishPositionBase = new Vector3(-7.56f, -4f, 0);


    void Start()
    {
        //transform.position = 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speedBase * Time.deltaTime, 0, 0);
        if(transform.position.x <= finishPositionBase.x)
        {
            transform.position = startPositionBase;
        }
    }
}

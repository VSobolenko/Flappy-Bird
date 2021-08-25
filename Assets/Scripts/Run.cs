using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Run : MonoBehaviour
{
    
    public float speed = 1;
    public GameObject Pause1;
    private void Start()
    {

    }
    void Update()
    {
        transform.Translate( Time.deltaTime * -SpaunerPipe.speedForScript, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("SceneMenu");
        }
    }
    
}

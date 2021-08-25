using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controllermod3 : MonoBehaviour
{
    public UnityEngine.Vector2 direction;
    public float accerleration;
    public Rigidbody2D rb;

    public uint Score = 0;
    public static uint bestScore;

    public Text nowScore;

    private void Awake()
    {
        //DontDestroyOnLoad(gameObject);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(direction.normalized * accerleration, ForceMode2D.Impulse);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Count")
        {
            Score++;
            nowScore.text = Score.ToString();
            if (Score > bestScore)
                bestScore = Score;
            Debug.Log("Score: " + Score);
            Debug.Log("Best score: " + bestScore);
        }
    }
}

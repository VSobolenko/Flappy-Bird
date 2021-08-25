using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Vector3 nowPosition;
    public float smoothing = 1;
    public float FlightAltitude = 5;

    private void Awake()
    {
        Rigidbody2D myrigic = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        nowPosition = transform.position;
        nowPosition.y += FlightAltitude;
        if (Input.GetMouseButtonDown(0))
        {
            transform.position = Vector3.Lerp(transform.position, nowPosition, smoothing * Time.deltaTime);
        }
    }
}

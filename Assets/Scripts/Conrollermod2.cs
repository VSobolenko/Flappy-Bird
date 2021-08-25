using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conrollermod2 : MonoBehaviour
{
    [SerializeField]
    private float forceGravity = 1f;
    [SerializeField]
    private float speedForceGravity = 1f;
    [SerializeField]
    private float liftingHeight = 1f;
    private float nowForceGravity;

    private Vector2 position = new Vector2(0,0);

    private void Start()
    {
        nowForceGravity = forceGravity;
    }
    private void Update()
    {
        forceGravity += speedForceGravity;
        transform.Translate(0, -forceGravity * Time.deltaTime, 0);
        if (Input.GetMouseButtonDown(0))
        {
            //transform.position.y { liftingHeight; }
        }
    }

}

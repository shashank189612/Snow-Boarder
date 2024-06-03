using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb2d;
    [SerializeField] float torque = 2;
    [SerializeField] float baseSpeed = 25f;
    [SerializeField] float boostSpeed = 50f;

    bool canMove = true;

    SurfaceEffector2D surfaceEffector;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        surfaceEffector = FindObjectOfType<SurfaceEffector2D>();
        // baseSpeed = surfaceEffector.speed;

    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            playerRotate();
            playerBoost();
        }


    }

    public void DisablePLayerControls()
    {
        canMove = false;
    }

    void playerBoost()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector.speed = boostSpeed;
        }
        else
        {
            surfaceEffector.speed = baseSpeed;
        }
    }

    void playerRotate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torque);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torque);
        }
    }
}

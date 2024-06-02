using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb2d;
    [SerializeField] float torque = 2;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

    
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torque);
        }else if(Input.GetKey(KeyCode.RightArrow)){
            rb2d.AddTorque(-torque);

        }else{
            
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCar : MonoBehaviour
{
    private float accel = 10;
    private float deccel = 15;
    private float maxSpeed = 100;
    private float speed = 0;

    private float steerInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Vertical"))
        {
            speed = speed - (accel * Time.deltaTime);
        }

        steerInput = Input.GetAxis("Horizontal");
    }
}

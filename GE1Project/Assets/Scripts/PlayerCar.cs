using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCar : MonoBehaviour
{
    private bool accelerating = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Forward"))
        {
            accel = true;
        }

        steerInput = Input.GetAxis("Horizontal");
    }
}

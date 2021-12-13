using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCar : MonoBehaviour
{
    public float accel = 10;
    public float deccel = 15;
    public float maxSpeed = 100;
    private float speed = 0;

    private float steerInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Vertical") && speed<maxSpeed)
        {
            speed = speed - (accel * Time.deltaTime);
        }

        else
        {
            if(speed > (deccel * Time.deltaTime))
            {
                speed = speed - (deccel * Time.deltaTime);
            }
            else
            {
                speed = 0;
            }
        }

        steerInput = Input.GetAxis("Horizontal");

        transform.position = new Vector3(transform.position.x + speed, transform.position.y , transform.position.z);
    }
}

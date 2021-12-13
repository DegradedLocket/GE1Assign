using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCar : MonoBehaviour
{
    private bool accel = false;
    private bool deccel = false;
    private float maxSpeed = 100;
    public float speed = 0;

    private Rigidbody carRB;

    private float steerInput;
    // Start is called before the first frame update
    void Awake()
    {
        carRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Vertical"))
        {
            //speed = speed - (accel * Time.deltaTime);

            accel = true;
        }
        else
        {
            /*if(speed > (deccel * Time.deltaTime))
            {
                speed = speed - (deccel * Time.deltaTime);
            }
            else if(speed <-(deccel * Time.deltaTime))
            {
                speed = speed + (deccel * Time.deltaTime);
            }
            else
            {
                speed = 0;
            }*/

            accel = false;
        }
        steerInput = Input.GetAxis("Horizontal");
    }

        
    void FixedUpdate() {
        float temp = 0f;
        float steering = Mathf.Lerp(steerInput, temp, 0.5f);

        if(accel)
        {
            carRB.AddForce(transform.forward * speed, ForceMode.Acceleration);
            deccel = false;
        }

        carRB.transform.Rotate(new Vector3(0f, steering, 0f));

        //transform.position = new Vector3(transform.position.x + speed, transform.position.y , transform.position.z);
    }
}

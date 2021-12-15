using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCar : MonoBehaviour
{
    private bool accel = false;

    private float maxSpeed = 100;
    public float speed = 0;

    public float hoverH = 2f;
    public float hoverForce = 65f;

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

        //keep camra locked on y axis

        
    }

        
    void FixedUpdate() {
        float temp = 0f;
        float steering = Mathf.Lerp(steerInput, temp, 0.5f);

        //logic to have car hover
        Ray ray = new Ray(transform.position, -transform.up);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, hoverH))
        {
            float propH = (hoverH - hit.distance) / hoverH;
            Vector3 actHoverForce = Vector3.up * propH *  hoverForce;

            carRB.AddForce(actHoverForce, ForceMode.Acceleration);
        }
        

        if(accel)
        {
            carRB.drag = 0;
            carRB.AddForce(transform.forward * speed, ForceMode.Acceleration);
        }
        else
        {
            carRB.drag = 2;
        }

        carRB.transform.Rotate(new Vector3(0f, steering * 3, 0f));

        //transform.position = new Vector3(transform.position.x + speed, transform.position.y , transform.position.z);
    }
}

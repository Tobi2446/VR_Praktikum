using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyJoystick : MonoBehaviour
{
    public float speed;
    public float speedAmplifier;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputPitch = Input.GetAxis("Pitch") ;
        float inputYawn = Input.GetAxis("Yawn") * Time.deltaTime * rotationSpeed;
        speed = Input.GetAxis("Throttle");
        float inputRoll = Input.GetAxis("Roll");

        this.transform.Rotate(new Vector3(-1,0,0) * inputPitch * Time.deltaTime * rotationSpeed);
        this.transform.Rotate(new Vector3(0,1,0) * inputRoll * Time.deltaTime * rotationSpeed);
        this.transform.Rotate(new Vector3(0,0,1) * inputYawn);

        this.transform.Translate(Vector3.forward *speed * Time.deltaTime * speedAmplifier); 
        
    }
}

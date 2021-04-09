using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayFlightData : MonoBehaviour
{
    public Text textSpeed;
    public Text textHeight;
    public GameObject player;
    public float warningHeight;
    public GameObject warnImage;
    private FlyJoystick flyJoystick;
    private int wert;
    private int speed;

    // Start is called before the first frame update
    void Start()
    {
        flyJoystick = player.GetComponent<FlyJoystick>();
    }

    // Update is called once per frame
    void Update()
    {
        wert = (int) player.transform.position.y;
        textHeight.text = "Alt: " + wert + "m";

        speed = (int) flyJoystick.speed;
        int speedAmplifier = (int) flyJoystick.speedAmplifier;
        textSpeed.text = "Speed: " + speed*speedAmplifier + "km/h";

        if (wert < warningHeight) {
        warnImage.SetActive(true);
        textHeight.color = Color.red; 
        //StartCoroutine(Blink());
        }
        else {
        warnImage.SetActive(false);
        textHeight.color = Color.gray;
        }
    }

    //void Blink(){
        //textHeight.renderer.enabled = false;
        //yield WaitForSeconds(0.2);
        //textHeight.renderer.enabled = true;
    //}
}

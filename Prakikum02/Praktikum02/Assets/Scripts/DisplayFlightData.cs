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
    public AudioSource ton;

    // Start is called before the first frame update
    void Start()
    {
        flyJoystick = player.GetComponent<FlyJoystick>();
        ton = this.GetComponent<AudioSource>();
        ton.mute = true;
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
     
        }
        else {
        warnImage.SetActive(false);
        textHeight.color = Color.gray;
        ton.mute = true;
        }
        if ( wert < warningHeight-20) {
            ton.mute = false;
            StartCoroutine(BlinkText());
        }
    
    
    IEnumerator BlinkText()
    {
        while (wert<warningHeight-20)
        {
            warnImage.SetActive(false);
            yield return new WaitForSeconds(.5f);
            warnImage.SetActive(true);
            yield return new WaitForSeconds(.5f);
        }
    }
}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zeit : MonoBehaviour
{
    private Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<Text>();
        InvokeRepeating("TimerUpdate", 0,1);
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = "Flugzeit: " + Mathf.Round(Time.time);
    }
}

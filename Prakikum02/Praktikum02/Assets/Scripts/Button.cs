using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
   private bool isPressed = false;
   private float lastAction = 0;
   public GameObject HUD;
   public AudioClip klicken;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
      if((Time.time - lastAction) > 0.5) {
      if(!isPressed) {
      this.transform.position += new Vector3(0,0,0.01f);
      isPressed = true;
      HUD.SetActive(false);
      AudioSource.PlayClipAtPoint(klicken, transform.position, 1);
      lastAction = Time.time;
      } else{
        this.transform.position -= new Vector3(0,0,0.01f);
        isPressed = false;
        HUD.SetActive(true);
        AudioSource.PlayClipAtPoint(klicken, transform.position, 1);
        lastAction = Time.time;
      }
    }

}
}



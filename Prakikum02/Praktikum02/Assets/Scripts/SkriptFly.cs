using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkriptFly : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) { 
            this.transform.Translate (Vector3.forward* speed * Time.deltaTime); 
            }
        if(Input.GetKey(KeyCode.A)) { 
            this.transform.Rotate (new Vector3(0,-1,0) * speed * Time.deltaTime);
             }
        if(Input.GetKey(KeyCode.S)) { 
            this.transform.Translate (-1* Vector3.forward * speed * Time.deltaTime); 
            }
        if(Input.GetKey(KeyCode.D)) { 
            this.transform.Rotate (new Vector3(0,1,0) * speed * Time.deltaTime); 
            }
        if(Input.GetKey(KeyCode.Q)) { 
            this.transform.Translate (Vector3.down * speed * Time.deltaTime);
            }
        if(Input.GetKey(KeyCode.E)) { 
            this.transform.Translate (Vector3.up * speed * Time.deltaTime); 
            }
    }
}

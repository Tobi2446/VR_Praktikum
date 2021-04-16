using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horizon : MonoBehaviour
{
    public GameObject ground;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = ground.transform.rotation;
    }
}

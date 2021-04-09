using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour
{
    public GameObject player;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = player.transform.position + distance * player.transform.forward;
        this.transform.LookAt(player.transform.position);
        this.transform.Rotate(new Vector3(0,180,0));
    }
}

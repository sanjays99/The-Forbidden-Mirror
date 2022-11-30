using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoMovement : MonoBehaviour
{
    float time = 0;
    public float t = 1f; // speed
    public float l = 10f; // length from 0 to endpoint.
    public float posX = 1f; // Offset
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(0,posX + Mathf.PingPong(t * Time.time, l), 0);
        transform.position = pos;
    }

    void logomove()
    {
        
    }
}

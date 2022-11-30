using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    public GameObject playercamera;
    public GameObject cctv1;
    public GameObject cctv2;
    public int camswitch = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("camera") && camswitch ==0)
        {
            cctv1.SetActive(true);
            camswitch = 1;
        }
        else if (Input.GetButtonDown("camera") && camswitch == 1)
        {
            cctv2.SetActive(true);
            cctv1.SetActive(false);
            //playercamera.SetActive(false);
            camswitch = 2;
        }
        else if(Input.GetButtonDown("camera") && camswitch == 2)
        {
            cctv2.SetActive(false);
            cctv1.SetActive(false);
            playercamera.SetActive(true);
            camswitch = 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerControl : MonoBehaviour
{
    public GameObject interactivepanel;
    public bool drawopen = false;
    public bool xyz = true;
    public Transform drawer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("weaponpick"))
        {
            if (drawopen == true && xyz == true)
            {
                interactivepanel.SetActive(false);
                drawer.transform.Translate(0, 0, 0.5f);
                xyz = false;
                
            }
            

        }
    }
    void OnTriggerEnter(Collider dcollider)
    {
        if (dcollider.gameObject.tag == "Player")
        {
            Debug.Log("entered");
            drawopen = true;
            interactivepanel.SetActive(true);
        }

    }
    void OnTriggerStay(Collider dcollider)
    {
        drawopen = true;
        interactivepanel.SetActive(true);
    }

    void OnTriggerExit(Collider dcollider)
    {
        
        interactivepanel.SetActive(false);
    }
}

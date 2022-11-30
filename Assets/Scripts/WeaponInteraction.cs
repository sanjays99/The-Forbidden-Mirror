using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WeaponInteraction : MonoBehaviour
{
    public GameObject interactivepanel;
    public bool weaponavail = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            Debug.Log("entered");
            weaponavail = true;
            interactivepanel.SetActive(true);
        }
        
    }

    void OnTriggerStay(Collider collider)
    {
        weaponavail = true;
        interactivepanel.SetActive(true);
    }

    void OnTriggerExit(Collider collider)
    {
        weaponavail = false;
        interactivepanel.SetActive(false);
    }
}

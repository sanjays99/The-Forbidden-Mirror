using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponInteraction : MonoBehaviour
{
    //public GameObject interactivepanel;
    public bool weaponavail = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider ecollider)
    {
        if (ecollider.gameObject.tag == "Enemy")
        {
            Debug.Log("entered");
            weaponavail = true;
            //interactivepanel.SetActive(true);
        }

    }

    void OnTriggerStay(Collider ecollider)
    {
        weaponavail = true;
        //interactivepanel.SetActive(true);
    }

    void OnTriggerExit(Collider ecollider)
    {
        weaponavail = false;
        //interactivepanel.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialrules : MonoBehaviour
{
    public GameObject Rulepanel;
    // Start is called before the first frame update
    void Start()
    {
        Rulepanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("weaponpick"))
        {
            Rulepanel.SetActive(false);
        }
    }

   

    
}

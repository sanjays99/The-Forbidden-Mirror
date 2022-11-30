using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredTut : MonoBehaviour
{
    public GameObject gunRulepanel;
    public GameObject trigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            gunRulepanel.SetActive(false);
        }
    }
    void OnTriggerEnter(Collider ecollider)
    {
         gunRulepanel.SetActive(true);
    }
    void OnTriggerExit(Collider ecollider)
    {
        gunRulepanel.SetActive(false);
        Destroy(trigger);
    }
}

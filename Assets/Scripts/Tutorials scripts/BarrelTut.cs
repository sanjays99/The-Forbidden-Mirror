using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelTut : MonoBehaviour
{
    public GameObject btut;
    public GameObject trigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            btut.SetActive(false);
        }
    }
    void OnTriggerEnter(Collider ecollider)
    {
        btut.SetActive(true);
    }
    void OnTriggerExit(Collider ecollider)
    {
        btut.SetActive(false);
        Destroy(trigger);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SameGunRules : MonoBehaviour
{
    [SerializeField] Weaponcontrol wc;
    [SerializeField] Enemyweaponcontrol ec;
    public GameObject samegunpanel;
    public GameObject trigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("weapondrop"))
        {
            samegunpanel.SetActive(false);
        }
        if (wc.gunequip == true && ec.gunequip == true)
        {
            trigger.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider ecollider)
    {
        if(wc.gunequip== true && ec.gunequip == true)
        {
            samegunpanel.SetActive(true);
        }
    }
    void OnTriggerExit(Collider ecollider)
    {
        
            samegunpanel.SetActive(false);
        
    }
}

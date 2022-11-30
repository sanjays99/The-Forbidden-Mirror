using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyweaponcontrol : MonoBehaviour
{
    [SerializeField] EnemyWeaponInteraction wi;
    public GameObject gun;
    public bool gunequip = false;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {


        if (Input.GetButtonDown("weaponpick"))
        {
            if (wi.weaponavail == true)
            {
                gun.SetActive(true);
                gunequip = true;
            }


        }
        if (Input.GetButtonDown("weapondrop"))
        {

            gun.SetActive(false);
            gunequip = false;



        }

    }
}

using System;
using System.Diagnostics;
using UnityEngine;

public class EGunforbarel : MonoBehaviour
{
    [SerializeField] Enemyweaponcontrol wc;
    [SerializeField] float damage = 10f;
    [SerializeField] float range = 100f;
    [SerializeField] float fireRate = 15f;
    [SerializeField] float impactForce = 30f;

    [SerializeField] Camera fpscamera;
    public GameObject barrier;

    private float nextTimeToFire = 0f;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            if (wc.gunequip == true)
            {
                barrier.SetActive(false);
                Shoot();
            }
        }

    }

    void Shoot()
    {

        RaycastHit hit;
        if (Physics.Raycast(fpscamera.transform.position, fpscamera.transform.forward, out hit, range))
        {
            barreltarget target = hit.transform.GetComponent<barreltarget>();
            if (target != null)
            {
                
                    
                    target.TakeDamage(damage);
                
            }

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }

        }

    }
}
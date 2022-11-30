using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemygun : MonoBehaviour
{
    [SerializeField] Enemyweaponcontrol ec;
    [SerializeField] float damage = 10f;
    [SerializeField] float range = 100f;
    [SerializeField] float fireRate = 15f;
    [SerializeField] float impactForce = 30f;
    public GameObject barrier;
    [SerializeField] Camera fpscamera;
    //[SerializeField] ParticleSystem muzzleflash;
    //[SerializeField] GameObject impactEffect;

    private float nextTimeToFire = 0f;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            if(ec.gunequip == true)
            {
                barrier.SetActive(false);
                Shoot();
            }
            
        }

    }

    void Shoot()
    {
        //muzzleflash.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpscamera.transform.position, fpscamera.transform.forward, out hit, range))
        {
            //UnityEngine.Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            ObjTarget obj = hit.transform.GetComponent<ObjTarget>();
            if (target != null)
            {
                
                    target.TakeDamage(damage);
                barrier.SetActive(true);

            }
            if (obj != null)
            {


                obj.TakeDamage(damage);
                barrier.SetActive(true);
            }
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
                barrier.SetActive(true);
            }

            //GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            //Destroy(impactGO, 2f);
        }

    }
}

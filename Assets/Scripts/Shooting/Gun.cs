using System;
using System.Diagnostics;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    [SerializeField] Weaponcontrol wc;
    [SerializeField] float damage = 10f;
    [SerializeField] float range = 100f;
    [SerializeField] float fireRate = 15f;
    [SerializeField] float impactForce = 30f;
    [SerializeField] Camera fpscamera;
    public GameObject barrier;
    private float nextTimeToFire = 0f;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            if (wc.gunequip == true)
            {
                source.PlayOneShot(clip);
                barrier.SetActive(false);
                Shoot();
                barrier.SetActive(true);
            }
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpscamera.transform.position, fpscamera.transform.forward, out hit, range))
        {
            EnemyTarget target = hit.transform.GetComponent<EnemyTarget>();
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
        }
    }
}
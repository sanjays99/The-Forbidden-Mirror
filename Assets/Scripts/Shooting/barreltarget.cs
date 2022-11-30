using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class barreltarget : MonoBehaviour
{
    
    public GameObject bd;
    Barrel d;
    Blastwave b;
    public float health = 50f;
    public GameObject barrelobj;
    public GameObject enemy;
    public float distance;
    [SerializeField] Text disctanceborad;

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0f)
        {
            Audios a = FindObjectOfType<Audios>();
            a.explosionsound();
            Die();

        }
    }

    void Update()
    {
        distance = Vector3.Distance(barrelobj.transform.position, enemy.transform.position);
        //disctanceborad.text = distance.ToString();
    }

    
    void Die()
    {
        
        if (distance <= 4)
        {
            Barrel d = FindObjectOfType<Barrel>();
            Blastwave b = FindObjectOfType<Blastwave>();
            Destroy(barrelobj);
            Destroy(enemy);
            d.explode();
            b.blasts();
            bd.SetActive(true);
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            
        }

        if (distance > 4)
        {
            Barrel d = FindObjectOfType<Barrel>();
            Blastwave b = FindObjectOfType<Blastwave>();
            Destroy(barrelobj);
            d.explode();
            b.blasts();
            
        }

    }
}

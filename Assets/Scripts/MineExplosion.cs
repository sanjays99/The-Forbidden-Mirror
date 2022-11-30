using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MineExplosion : MonoBehaviour
{
    Barrel d;
    Blastwave b;
    public GameObject barrelobj;
    public GameObject enemy;
    public GameObject player;
    public float distance;
    public float pdistance;
    public GameObject congopanel;
    public Text cp;
    public Text dp;
    public GameObject deathpanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(barrelobj.transform.position, enemy.transform.position);
        pdistance = Vector3.Distance(barrelobj.transform.position, player.transform.position);
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Enemy" || collider.tag == "eobjects")
        {
            if (distance <= 4)
            {
                Barrel d = FindObjectOfType<Barrel>();
                Blastwave b = FindObjectOfType<Blastwave>();
                Destroy(barrelobj);
                Destroy(enemy);
                congopanel.SetActive(true);
                cp.text = "You killed the enemy with a LandMine!";
                Time.timeScale = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                d.explode();
                b.blasts();
                Audios a = FindObjectOfType<Audios>();
                a.explosionsound();
            }
            if (distance > 4)
            {
                Barrel d = FindObjectOfType<Barrel>();
                Blastwave b = FindObjectOfType<Blastwave>();
                Destroy(barrelobj);
                d.explode();
                b.blasts();
                Audios a = FindObjectOfType<Audios>();
                a.explosionsound();
            }
        }
        if (collider.tag == "Player" || collider.tag == "pobjects")
        {
            if (pdistance <= 4)
            {
                Barrel d = FindObjectOfType<Barrel>();
                Blastwave b = FindObjectOfType<Blastwave>();
                Destroy(barrelobj);
                Destroy(player);
                deathpanel.SetActive(true);
                dp.text = "You got killed by a LandMine!";
                Time.timeScale = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                d.explode();
                b.blasts();
                Audios a = FindObjectOfType<Audios>();
                a.explosionsound();
            }
            if (pdistance > 4)
            {
                Barrel d = FindObjectOfType<Barrel>();
                Blastwave b = FindObjectOfType<Blastwave>();
                Destroy(barrelobj);
                d.explode();
                b.blasts();
                Audios a = FindObjectOfType<Audios>();
                a.explosionsound();
            }
        }
    }
}

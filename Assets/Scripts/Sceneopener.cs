using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneopener : MonoBehaviour
{
    public GameObject ecs;
    public GameObject mainpanel;
    public GameObject creditpanel;
    public GameObject optpanel;
    bool escapeopt = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
             Time.timeScale = 0;
             Cursor.visible = true;
             Cursor.lockState = CursorLockMode.None;
             ecs.SetActive(true);
        }
    }

    public void resume()
    {
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        ecs.SetActive(false);
    }

    public void scene1()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }
    public void scene0()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 0;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }
    public void scene2()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }
    public void scene3()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }
    public void tutorial()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    public void quit()
    {
        Application.Quit();
    }

    public void credits()
    {
        mainpanel.SetActive(false);
        creditpanel.SetActive(true);
    }
    public void back()
    {
        mainpanel.SetActive(true);
        optpanel.SetActive(false);
        creditpanel.SetActive(false);
    }
    public void options()
    {
        optpanel.SetActive(true);
        mainpanel.SetActive(false);
    }
    public void ingameoptions()
    {
        optpanel.SetActive(true);
    }
    public void ingameback()
    {
        optpanel.SetActive(false);
    }
}

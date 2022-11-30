using UnityEngine;

public class Target : MonoBehaviour
{
    
    Death d;
    public float health = 50f;
    public GameObject enemy;
    
    public void TakeDamage(float amount)
    {
        health -= amount;
        
        if (health <= 0f)
        {
            
            Die();
            
        }
    }
    
    void Die()
    {
        Death d = FindObjectOfType<Death>();
        Destroy(enemy);
        d.explode();
        Time.timeScale = 0;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }

}
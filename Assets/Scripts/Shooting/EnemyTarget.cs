using UnityEngine;

public class EnemyTarget : MonoBehaviour
{
    
    EDeath e;
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
        EDeath e = FindObjectOfType<EDeath>();
        Destroy(enemy);
        e.explode();
        Time.timeScale = 0;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }

}
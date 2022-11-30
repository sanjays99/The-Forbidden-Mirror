using UnityEngine;

public class ObjTarget : MonoBehaviour
{
    
    public GameObject enemy;
    
    public void TakeDamage(float amount)
    {
        Destroy(enemy);
    }
    

}
using UnityEngine;

public class DangerIce : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("OUCH !!! ");
        }
    }
    
        
    
}

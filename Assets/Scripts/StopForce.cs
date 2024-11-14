using UnityEngine;

public class StopForce : MonoBehaviour
{
    public GameObject stopForceTrigger;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerLoco.isInSecondZone = false;

        }
    }
}

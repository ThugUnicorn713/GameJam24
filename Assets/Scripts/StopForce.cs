using UnityEngine;

public class StopForce : MonoBehaviour
{
    public Camera cam;
    public GameObject stopForceTrigger;
    public float zone3YPosition = -310.15f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerLoco.isInSecondZone = false;

            cam.transform.position = new Vector3(cam.transform.position.x, zone3YPosition, cam.transform.position.z);
        }
    }
}

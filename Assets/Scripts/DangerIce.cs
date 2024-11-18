using UnityEngine;

public class DangerIce : MonoBehaviour
{
    public GameObject player;
    public GameObject respawnPoint;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            RespawnPlayer();
        }
    }

    public void RespawnPlayer()
    {
        player.transform.position = respawnPoint.transform.position;
        PlayerLoco.isInSecondZone = false;
    }

}

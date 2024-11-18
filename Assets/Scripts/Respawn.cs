using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject buildHead;
    public GameObject buildMed;
    public GameObject buildBottom;
    public GameObject respawnSnowman;
    public GameObject respawnWall;
   
    

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           buildBottom.SetActive(false);
           buildMed.SetActive(false);
           buildHead.SetActive(false);
           respawnSnowman.SetActive(true);
           respawnWall.SetActive(true);

        }
    }

   
}

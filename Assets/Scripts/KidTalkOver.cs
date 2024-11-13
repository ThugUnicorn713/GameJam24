using UnityEngine;

public class KidTalkOver : MonoBehaviour
{
    public GameObject kidTalks;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (kidTalks != null) 
            {
                Destroy(kidTalks);
                Debug.Log("Player can no longer talk to kid");
            }
                

        }

    }
}

using UnityEngine;

public class BumSTOP : MonoBehaviour
{
    public GameObject bumStopTrigger;
    public GameObject bumTalks;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has entered");

            if (bumTalks != null)
            {
                bumTalks.SetActive(false);
            }


        }

    }
}

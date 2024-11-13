using TMPro;
using UnityEngine;

public class KidImWeird : MonoBehaviour
{
    public GameObject kidImWeirdTrigger;
    public GameObject kidTalksTrigger;
    public GameObject kidTalks;
    public TextMeshProUGUI kidImWeirdText;
    public TextMeshProUGUI kidCoolText;
   

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has entered");
            kidCoolText.gameObject.SetActive(false);
            
            Collider2D triggerCollider = kidTalksTrigger.GetComponent<Collider2D>();
            if (triggerCollider != null)
            {
                triggerCollider.enabled = false;
            }
            kidTalks.SetActive(true);
            kidImWeirdText.gameObject.SetActive(true);
        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has exited");

            if (kidTalks != null)
            {
                kidTalks.SetActive(false);
            }

        }

    }
}

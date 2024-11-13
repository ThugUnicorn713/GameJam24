using TMPro;
using UnityEngine;

public class KidYourWeird : MonoBehaviour
{
    public GameObject kidYourWeirdTrigger;
    public GameObject kidTalksTrigger;
    public GameObject kidTalks;
    public TextMeshProUGUI kidPlayerWeirdText;
    public TextMeshProUGUI kidWeirdText;
   


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {     
           Debug.Log("Player has entered");
            
            Collider2D triggerCollider = kidTalksTrigger.GetComponent<Collider2D>();
            if (triggerCollider != null)
            {
                triggerCollider.enabled = false;
            }

           kidWeirdText.gameObject.SetActive(false);
           kidTalks.SetActive(true);
           kidPlayerWeirdText.gameObject.SetActive(true);
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

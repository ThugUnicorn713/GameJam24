using TMPro;
using UnityEngine;

public class BumTalks : MonoBehaviour
{
    public GameObject bumTalksTrigger;
    
    public GameObject bumTalks;

    public TextMeshProUGUI bumCarrotText;
    
    public void Start()
    {
        bumTalks.SetActive(true);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has entered");

            if (bumTalks != null)
            {
                bumCarrotText.gameObject.SetActive(true);
            }


        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has exited");

           if (bumTalks != null)
           {
                bumCarrotText.gameObject.SetActive(false);
           }

        }

    }

}

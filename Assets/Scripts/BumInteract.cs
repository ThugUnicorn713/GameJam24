using TMPro;
using UnityEngine;

public class BumInteract : MonoBehaviour
{
    public GameObject bumInterTrigger;
    public TextMeshProUGUI bumInterText;
    public GameObject bumTalks;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has entered");

            if (bumTalks != null)
            {
                bumInterText.gameObject.SetActive(true);
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
                bumInterText.gameObject.SetActive(false);
            }

        }

    }
}

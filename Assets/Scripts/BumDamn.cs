using TMPro;
using UnityEngine;

public class BumDamn : MonoBehaviour
{
    public GameObject bumDamnTrigger;
    public GameObject bumTalks;
    public TextMeshProUGUI bumDamnText;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has entered");

            if (bumTalks != null)
            {
                bumDamnText.gameObject.SetActive(true);
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
                bumDamnText.gameObject.SetActive(false);
            }

        }

    }

}

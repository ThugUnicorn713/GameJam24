using TMPro;
using UnityEngine;

public class BumJump : MonoBehaviour
{
    public GameObject bumTalks;
    public GameObject bumJumpTrigger;
    public TextMeshProUGUI bumJumpText;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has entered");

            if (bumTalks != null)
            {
                bumJumpText.gameObject.SetActive(true);
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
                bumJumpText.gameObject.SetActive(false);
            }

        }

    }
}

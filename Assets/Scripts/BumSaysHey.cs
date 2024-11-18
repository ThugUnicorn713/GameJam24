using TMPro;
using UnityEngine;

public class BumSaysHey : MonoBehaviour
{
    public GameObject bumTalksZone3;
    public TextMeshProUGUI heyKidText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bumTalksZone3.SetActive(true);
            heyKidText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            heyKidText.gameObject.SetActive(false);
        }
    }
}

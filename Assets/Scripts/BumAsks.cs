using TMPro;
using UnityEngine;

public class BumAsks : MonoBehaviour
{
    public GameObject bumTalksZone3;
    public TextMeshProUGUI youSureText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bumTalksZone3.SetActive(true);
            youSureText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            youSureText.gameObject.SetActive(false);
        }
    }
}

using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerTalks : MonoBehaviour
{
    public GameObject startText;
    public GameObject goToStoreText;
    public GameObject playerBubble;
    
    private void Start()
    {
        playerBubble.SetActive(true);
        startText.gameObject.SetActive(true);
    }

    private void Update()
    {
        if (startText.activeSelf)
        {
            Invoke(nameof(SecondText), 6f);
        }

        if(goToStoreText.activeSelf)
        {
            Invoke(nameof(TurnOffPlayerBubble), 6f);
        }
    }

    public void SecondText()
    {
        startText.gameObject.SetActive(false);
        goToStoreText.gameObject.SetActive(true);

    }

    public void TurnOffPlayerBubble()
    {
        goToStoreText.gameObject.SetActive(false);
        playerBubble.SetActive(false);
    }


}

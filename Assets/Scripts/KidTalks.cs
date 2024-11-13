using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class KidTalks : MonoBehaviour
{
    public GameObject kidTalks;
    public GameObject playerChoicePanel;
    public GameObject playerFirstChoice;
    public GameObject playerSecondChoice;
    public GameObject playerHaveEyesPanel;

    public GameObject kidTalkTrigger;
    public GameObject kidImWeirdTrigger;
    public GameObject kidYourWeirdTrigger;
    public GameObject kidTalkOVERTrigger;

    public TextMeshProUGUI kidWeirdText;
    public TextMeshProUGUI kidCoolText;
    
    public TextMeshProUGUI kidWantEyesText;
    public TextMeshProUGUI kidNotLikeThatText;
    public TextMeshProUGUI kidBeThatWayText;
    public TextMeshProUGUI kidSeeYaText;

    public Rigidbody2D playerRB;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            kidTalks.SetActive(true);

            Debug.Log("Player has entered");

        }

        if (other.CompareTag("Player") && kidBeThatWayText != null)
        {
            kidBeThatWayText.gameObject.SetActive(false);
            kidWantEyesText.gameObject.SetActive(true);
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

    public void InteractWithKid()
    {
        playerChoicePanel.SetActive(true);
    }

    public void GetWeirdText()
    {
        if (kidTalks != null)
        {
            kidWantEyesText.gameObject.SetActive(false);
            kidWeirdText.gameObject.SetActive(true);
            playerFirstChoice.SetActive(false);
            playerHaveEyesPanel.SetActive(true);

            Button startButton = playerHaveEyesPanel.GetComponentInChildren<Button>();
            if (startButton != null)
            {
                startButton.Select();
            }
            kidYourWeirdTrigger.SetActive(true);

            kidTalkOVERTrigger.SetActive(true);
        }
        
    }

    public void GetNotLikeThatText()
    {
        if (kidTalks != null)
        {
            kidWantEyesText.gameObject.SetActive(false);
            kidNotLikeThatText.gameObject.SetActive(true);
            playerFirstChoice.SetActive(false);
            playerSecondChoice.SetActive(true);
            Button startButton = playerSecondChoice.GetComponentInChildren<Button>();
            if (startButton != null)
            {
                startButton.Select();
            }

        }

    }

    public void GetCoolText()
    {
        if (kidTalks != null)
        {
            if (kidWantEyesText != null)
            {
                kidWantEyesText.gameObject.SetActive(false);
            }

            kidNotLikeThatText.gameObject.SetActive(false);
            kidCoolText.gameObject.SetActive(true);
            playerSecondChoice.SetActive(false);
            playerHaveEyesPanel.SetActive(true);

            Button startButton = playerHaveEyesPanel.GetComponentInChildren<Button>();
            if (startButton != null)
            {
                startButton.Select();
            }
            kidImWeirdTrigger.SetActive(true);
            
            kidTalkOVERTrigger.SetActive(true);
        }

    }

    public void GetBeThatWayText()
    {
        if (kidTalks != null)
        {
            kidNotLikeThatText.gameObject.SetActive(false);
            kidBeThatWayText.gameObject.SetActive(true);
            playerChoicePanel.SetActive(false);

            Invoke(nameof(UnfreezePlayer), 2f);

        }

    }

    public void WeHaveTheEyesButton()
    {
        BuildSnowman.GiveEyes();
        
        kidTalks.SetActive(false);
        playerChoicePanel.SetActive(false);
        
        Collider2D triggerCollider = kidTalkTrigger.GetComponent<Collider2D>();
        if (triggerCollider != null)
        {
            triggerCollider.enabled = false;
        }
        
        playerRB.constraints = RigidbodyConstraints2D.FreezeRotation;
        

    }

    public void UnfreezePlayer()
    {
        playerRB.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

}

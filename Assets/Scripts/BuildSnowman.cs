using Unity.VisualScripting;
using UnityEngine;

public class BuildSnowman : MonoBehaviour
{
    public GameObject carrot;
    public GameObject armOne;
    public GameObject armTwo;

    public GameObject playerMiddle;
    public GameObject playerHead;
    public GameObject buildMiddle;

    public GameObject playerBubble;
    public GameObject needMoreText;
    public GameObject middleFirstText;


    public static bool doesHaveEyes = false;

    public void Build()
    {
        if (!carrot.activeSelf && !armOne.activeSelf && !armTwo.activeSelf && doesHaveEyes == true)
        {
            
            CheckIfMiddle();
        }
        else 
        {
            Debug.Log("We need more materials");
            MoreMaterialsText();
            Invoke(nameof(TurnOffMoreMaterials), 1f);
        }

    }

    public static void GiveEyes()
    {
        doesHaveEyes = true;
        Debug.Log("Player has eyes in system");
    }

    public void CheckIfMiddle()
    {
        if (this.gameObject.CompareTag("Middle"))
        {
            this.gameObject.SetActive(false);
            playerMiddle.SetActive(true);
        }
        else
        {
            Debug.Log("Need to pick up the Middle First");
            MiddleText();
            Invoke(nameof(TurnOffMiddleText), 3f);
        }
    }

    public void MoreMaterialsText()
    {
        playerBubble.SetActive(true);
        needMoreText.gameObject.SetActive(true);

    }

    public void TurnOffMoreMaterials()
    {
        playerBubble.SetActive(false);
        needMoreText.gameObject.SetActive(false);

    }

    public void MiddleText()
    {
        playerBubble.SetActive(true);
        middleFirstText.gameObject.SetActive(true);

    }

    public void TurnOffMiddleText()
    {
        playerBubble.SetActive(false);
        middleFirstText.gameObject.SetActive(false);
    }

}

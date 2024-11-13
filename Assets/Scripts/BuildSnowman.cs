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
        }
    }

    

}

using UnityEngine;

public class BuildSnowmanHead : MonoBehaviour
{
    public GameObject playerHead;
    public GameObject buildMiddle;

    public void CheckIfHead()
    {
        if (this.gameObject.CompareTag("Head") && buildMiddle.activeSelf)
        {
            this.gameObject.SetActive(false);
            playerHead.SetActive(true);
        }
        else
        {
            Debug.Log("Need to pick up the Middle First");
        }
    }
}

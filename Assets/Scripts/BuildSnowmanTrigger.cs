using UnityEngine;

public class BuildSnowmanTrigger : MonoBehaviour
{
    public GameObject playerMiddle;
    public GameObject playerHead;
    public GameObject buildBottom;
    public GameObject buildMiddle;
    public GameObject buildHead;
    public GameObject falseGround;
   
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && playerMiddle.activeSelf)
        {
            PlaceMiddle();
        }
        else
        {
            Debug.Log("I think we need the middle part first");
        }

        if(other.CompareTag("Player") && buildMiddle.activeSelf && playerHead.activeSelf) 
        {
            PlaceHead();
        }
        else
        {
            Debug.Log("I think we need the middle part first");
        }

        if(buildHead.activeSelf && buildMiddle.activeSelf && buildBottom.activeSelf)
        {
            falseGround.SetActive(false);
            CameraMove.ToggleCameraClamp(false);
            PlayerLoco.isInFirstZone = false;
            PlayerLoco.isInSecondZone = true;
        }

    }

    public void PlaceMiddle()
    {
        playerMiddle.SetActive(false);
        buildMiddle.SetActive(true);

    }

    public void PlaceHead()
    {
        playerHead.SetActive(false);
        buildHead.SetActive(true);

    }
}

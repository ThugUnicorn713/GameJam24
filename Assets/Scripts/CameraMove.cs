using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public Transform player;
    public float yPosition = 6.48f;

    private void LateUpdate()
    {
        if (player != null)
        {
            transform.position = new Vector3( player.position.x, yPosition, transform.position.z);
        }
    }
}

using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public Transform player;
    public float yPosition = 6.48f;
    public float zPosition = 0f;
    public static bool isClamped = true;

    private void LateUpdate()
    {
        if (player != null)
        {
            float yPos = isClamped ? yPosition : player.position.y;
            transform.position = new Vector3( player.position.x, yPos, transform.position.z);
            transform.rotation = Quaternion.identity;
        }
    }

    public static void ToggleCameraClamp(bool clamp)
    {
        isClamped = clamp;
    }
}

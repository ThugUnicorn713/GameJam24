using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLoco : MonoBehaviour
{
    public float speed;
    public float jumpDistance;
    public float jumpPower = 5f;
    public float windPower = 1f;
    public bool isInFirstZone;
   
    public Transform groundCheck;
    public LayerMask groundLayer;
    public LayerMask interactableLayer;

    

    
    private float horzional;

    public Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        isInFirstZone = true; 
    }

    public void Update()
    {
      rb.linearVelocity = new Vector2(horzional * speed, rb.linearVelocity.y);

        if (isInFirstZone)
        {
            AddWind();
        }

    }

    public void Move(InputAction.CallbackContext context)
    {
        horzional = context.ReadValue<Vector2>().x;
    }

    public void Jump(InputAction.CallbackContext context) 
    {
        if (context.performed && IsGrounded())
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpPower);
        } 
    }

    public void Interact(InputAction.CallbackContext context)
    {
            Debug.Log("I tried to interact!");

            Collider2D[] interactables = Physics2D.OverlapCircleAll(transform.position, 2f, interactableLayer);
            foreach (var interactable in  interactables) 
            {
                Interact interactScript = interactable.GetComponent<Interact>();
                if(interactScript != null)
                {
                    interactScript.OnInteract();
                }
            }   
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    public void AddWind()
    {
        rb.AddForce(new Vector2(-1, 0) * windPower);
    }
}

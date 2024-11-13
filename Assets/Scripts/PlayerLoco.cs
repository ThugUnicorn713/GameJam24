using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLoco : MonoBehaviour
{
    public float speed;
    public float pushPower = 10f;
    public float jumpPower = 5f;
    public float windPower = 1f;
    public static bool isInFirstZone;
    public float slideSpeed = 2;
    public float slopeThreshold = 30f;
    public static bool isInSecondZone;

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

        if (isInSecondZone)
        {
            AddPush();
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

                KidTalks talkScript = interactable.GetComponent<KidTalks>();
                if(talkScript != null)
                {
                    talkScript.InteractWithKid();
                    rb.constraints = RigidbodyConstraints2D.FreezeAll;

                }

                BuildSnowman buildSnowScript = interactable.GetComponent<BuildSnowman>();
                if(buildSnowScript != null)
                {
                    buildSnowScript.Build();
                }

                BuildSnowmanHead buildSnowHeadScript = interactable.GetComponent<BuildSnowmanHead>();
                if (buildSnowHeadScript != null)
                {
                    buildSnowHeadScript.CheckIfHead();
                }

            }   
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ice"))
        {
            foreach (ContactPoint contact in collision.contacts)
            {
                Vector3 normal = contact.normal;
                float slopeAngle = Vector3.Angle(normal, Vector3.up);

               
                

                if(slopeAngle > slopeThreshold)
                {
                    Vector3 slideDirection = new Vector3(normal.x, normal.y, normal.x);

                    rb.AddForce(slideDirection * slideSpeed, ForceMode2D.Impulse);
                }

            }

        }
        
    }

     void OnCollisionEnter2D(Collision2D collision)
     {
        if (collision.gameObject.CompareTag("Ice"))
        {
            pushPower = 50f;
        }
        
     }

    void OnCollisionExit2D(Collision2D collision)
     {
        if (collision.gameObject.CompareTag("Ice"))
        {
            this.transform.rotation = Quaternion.Euler(0f, 0f, -35f);
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

    public void AddPush()
    {
        rb.AddForce(new Vector2(1, 0) * pushPower);
    }
}

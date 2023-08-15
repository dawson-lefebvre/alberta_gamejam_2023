using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    IndigoInputActions Inputs;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Awake()
    {
        Inputs = new IndigoInputActions();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        Inputs.Enable();
    }

    private void OnDisable()
    {
        Inputs.Disable();
    }
    
    bool jumpDecelerate = false;
    void Update()
    {
        if (Inputs.Player.Jump.WasPressedThisFrame() && rb.velocity.y == 0)
        {
            Jump();
        }

        if (Inputs.Player.Jump.WasReleasedThisFrame() && rb.velocity.y > 0)
        {
            jumpDecelerate = true;
        }
    }

    [SerializeField] float maxSpeed = 1;
    [SerializeField] float acceleration = 1;
    [SerializeField] float jumpDecelSpeed = 1;
    bool facingRight = true;
    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(Inputs.Player.Move.ReadValue<Vector2>().x * acceleration, 0));

        if(rb.velocity.x > 0)
        {
            if(!facingRight)
            {
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                facingRight = true;
            }
        }
        else if (rb.velocity.x < 0) 
        {
            if(facingRight)
            {
                gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
                facingRight = false;
            }
        }

        if(rb.velocity.x > maxSpeed || rb.velocity.x < -maxSpeed)
        {
            if(rb.velocity.x > 0)
            {
                rb.velocity = new Vector2(maxSpeed, rb.velocity.y);
            }
            else
            {
                rb.velocity = new Vector2(-maxSpeed, rb.velocity.y);
            }
        }

        if (jumpDecelerate)
        {
            if(rb.velocity.y > 0)
            {
                rb.AddForce(Vector2.down * jumpDecelSpeed);
            }
            else
            {
                jumpDecelerate = false;
            }
            
        }
    }

    [SerializeField] float jumpForce = 1;
    void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

}

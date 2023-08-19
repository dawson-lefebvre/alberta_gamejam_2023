using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    PlayerControls playerControls;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Awake()
    {
        playerControls = new PlayerControls();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    private void Update()
    {
        Debug.Log(rb.velocity.magnitude);
    }

    public float acceleration = 1;
    public float maxSpeed = 10;
    // Update is called once per frame
    void FixedUpdate()
    {
        if(playerControls.Player.Move.ReadValue<Vector2>() != Vector2.zero)
        {
            rb.AddForce(playerControls.Player.Move.ReadValue<Vector2>() * acceleration);

        }
        else
        {
            rb.AddForce(-rb.velocity.normalized *  acceleration);
        }

        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
        else if (rb.velocity.magnitude < -maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * -maxSpeed;
        }
    }
}

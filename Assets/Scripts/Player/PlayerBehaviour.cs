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

    public float speed = 1;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = playerControls.Player.Move.ReadValue<Vector2>() * speed;
    }
}

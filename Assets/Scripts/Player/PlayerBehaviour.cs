using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    PlayerControls playerControls;
    Rigidbody2D rb;
    [SerializeField]GameObject beam; //Reference to the tractor beam object which is a child of the player

    [SerializeField] AudioSource beamFXSource;
    [SerializeField] AudioSource hoverFXSource;

    // Start is called before the first frame update
    void Awake()
    {
        playerControls = new PlayerControls();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        beamFXSource.loop = true;
        hoverFXSource.loop = true;
        beamFXSource.Play();
        hoverFXSource.Play();
        beamFXSource.Pause();
        hoverFXSource.Pause();
    }

    //To initalize the controls
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
        //Enables the beam if the tract button is held and disables if not
        if (playerControls.Player.Tract.IsPressed())
        {
            beam.SetActive(true);
            beamFXSource.UnPause();
        }
        else if(beam.activeInHierarchy)
        {
            beam.SetActive(false);
            beamFXSource.Pause();
        }
    }

    public float acceleration = 1;
    public float maxSpeed = 10;
    // Update is called once per frame
    void FixedUpdate()
    {
        if(playerControls.Player.Move.ReadValue<Vector2>() != Vector2.zero) //If the move value from input is not zero, adds force to the player with the acceleration value
        {
            rb.AddForce(playerControls.Player.Move.ReadValue<Vector2>() * acceleration);
            hoverFXSource.UnPause();

        }
        else //If the movement value is zero, a force with the acceleration force is applied negative to the velocity to slow it down
        {
            rb.AddForce(-rb.velocity.normalized *  acceleration);
            hoverFXSource.Pause();
        }

        //Speed limiter
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

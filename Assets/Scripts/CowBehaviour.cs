using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowBehaviour : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]GameObject pullPosition; //Position to tract towards when caught in beam

    [SerializeField] AudioClip bonkClip;
    [SerializeField] AudioClip collectionClip;
    [SerializeField] AudioSource source;

    [SerializeField] int FXDelayFramesDefault = 30;
    int FXDelayFrames;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        FXDelayFrames = FXDelayFramesDefault;
    }

    public float pullForce = 5;
    public float maxSpeed = 5;


    private void FixedUpdate()
    {
        FXDelayFrames--;
    }


    private void OnTriggerStay2D(Collider2D collision) //Runs every frame that the cow is in a trigger
    {
        if(collision.tag == "TractorBeam") //Runs if the trigger is the tractor beam
        {
            rb.AddForce((pullPosition.transform.position - gameObject.transform.position).normalized * pullForce); //Gets the direction between the cow and the pull position, then applies a force in that direction to the cow
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "CowBox") //Adds one to cows rescued and subtracts one from cows remaining after destroying itself
        {
            source.clip = collectionClip;
            source.Play();

            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<CircleCollider2D>().enabled = false;
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;

            Invoke("SelfDestruct", 1);

            Globals.cowsRescued++;
            Globals.cowsRemaining--;
        }
        else if(collision.tag == "KillBox") //Adds one to cows lost and subtracts one from cows remaining after destroying itself
        {
            Destroy(gameObject);
            Globals.cowsLost++;
            Globals.cowsRemaining--;
        }
    }

    private void SelfDestruct()
    {
        enabled = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (FXDelayFrames <= 0)
        {
            source.clip = bonkClip;
            source.Play();
            FXDelayFrames = FXDelayFramesDefault;
        };
    }


}

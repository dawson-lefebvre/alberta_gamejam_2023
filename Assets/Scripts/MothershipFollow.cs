using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MothershipFollow : MonoBehaviour
{
    [SerializeField] GameObject UFO;
    Rigidbody2D rb;
    Animator animator;
    public AnimationClip thumbsUp;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    public float maxDistance = 5;
    public float moveSpeed = 5;


    public int animationDelay = 20;
    int animationDelayFrames = -1;
    void FixedUpdate()
    {
        if (UFO.transform.position.y - gameObject.transform.position.y > maxDistance) //Sets the MotherShip to move upwards at moveSpeed if the difference in y positions between the player and mother ship is greater than the distance
        {
            rb.velocity = new Vector2(0, moveSpeed);

        }
        else if (UFO.transform.position.y - gameObject.transform.position.y < -maxDistance) //Sets the MotherShip to move downwards at moveSpeed if the difference in y positions between the player and mother ship is less than the negative distance
        {
            rb.velocity = new Vector2(0, -moveSpeed);
        }
        else //Stops mothership movement if the mother ship is within range of the player
        {
            rb.velocity = new Vector2(0, 0);
        }

        if(animationDelayFrames > 0)
        {
            animationDelayFrames--;
        }
        else if(animationDelayFrames == 0)
        {
            animator.Play("MotherShipThumbsReverse");
            animationDelayFrames--;
        }
    }

    public void ThumbsUp()
    {
        if (animationDelayFrames < 0)
        {
            animator.Play("MotherShipThumbs");
            animationDelayFrames = animationDelay;
        }
    }
}

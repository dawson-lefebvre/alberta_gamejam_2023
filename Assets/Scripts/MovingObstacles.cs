using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacles : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject LeftSide; //GameObject set to the left side out of bounds
    public GameObject RightSide; //GameObject set to the right side out of bounds
    public float speed = 1; //How fast the obstacle will move

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        rb.velocity = new Vector2(speed, 0); //Sets the movement speed permenantly
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == LeftSide && speed < 0) //Moves the obstacle back to the right side if it hits the left side and is moving left (negative speed)
        {
            gameObject.transform.position = new Vector3(RightSide.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        else if(collision.gameObject == RightSide && speed > 0) //Moves the obstacle back to the right side if it hits the left side and is moving left (positive speed)
        {
            gameObject.transform.position = new Vector3(LeftSide.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        }
    }
}

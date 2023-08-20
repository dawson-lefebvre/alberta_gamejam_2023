using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacles : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject Side1;
    public GameObject Side2;
    public float speed = 1;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        rb.velocity = new Vector2(speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Side1 && speed < 0)
        {
            gameObject.transform.position = new Vector3(Side2.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        else if(collision.gameObject == Side2 && speed > 0)
        {
            gameObject.transform.position = new Vector3(Side1.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        }
    }
}

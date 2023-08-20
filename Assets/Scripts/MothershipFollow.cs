using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MothershipFollow : MonoBehaviour
{
    [SerializeField] GameObject UFO;
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public float distance = 5;
    public float moveSpeed = 5;

    void FixedUpdate()
    {
        if (UFO.transform.position.y - gameObject.transform.position.y > distance)
        {
            rb.velocity = new Vector2(0, moveSpeed);

    }
        else if (UFO.transform.position.y - gameObject.transform.position.y < -distance)
        {
            rb.velocity = new Vector2(0, -moveSpeed);
    }
        else
        {
            rb.velocity = new Vector2(0,0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowBehaviour : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]GameObject pullPosition;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public float pullForce = 5;
    public float maxSpeed = 5;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "TractorBeam")
        {
            rb.AddForce((pullPosition.transform.position - gameObject.transform.position).normalized * pullForce);
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

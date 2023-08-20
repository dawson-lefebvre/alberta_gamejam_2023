using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MothershipFollow : MonoBehaviour
{
    [SerializeField] GameObject UFO;
    [SerializeField] Rigidbody rb;
    void FixedUpdate()
    {
        if (UFO.transform.position.y - gameObject.transform.position.y > 5)
        {
            rb.velocity = new Vector2(0, -(10));

    }
        else if (UFO.transform.position.y - gameObject.transform.position.y < -5)
        {
            rb.velocity = new Vector2(0, 10);
      
    }
        else
        {
            rb.velocity = new Vector2(0,0);
        }
    }
}

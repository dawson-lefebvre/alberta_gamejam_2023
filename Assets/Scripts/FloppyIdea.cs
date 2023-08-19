using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FloppyIdea : MonoBehaviour
{
    [SerializeField] GameObject LeftCorner;
    [SerializeField] GameObject RightCorner;
    [SerializeField] GameObject Direction;
    Rigidbody2D Rigidbody;
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame

    public float flopForce = 1;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody.AddForce((Camera.main.ScreenToWorldPoint(Input.mousePosition) - gameObject.transform.position).normalized * flopForce, ForceMode2D.Impulse);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            Rigidbody.AddForceAtPosition(Direction.transform.position - RightCorner.transform.position * flopForce, RightCorner.transform.position, ForceMode2D.Impulse);
        }
    }
}

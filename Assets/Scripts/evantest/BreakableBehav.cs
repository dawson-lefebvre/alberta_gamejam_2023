using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class BreakableBehav : MonoBehaviour
{
    [SerializeField] HingeJoint2D hinge;
    [SerializeField] KeyCode controlName;
    [SerializeField] float paddleSpeed;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Breaker")
        {
            //"Unlock" a bunch of broken pieces that lose all collision and fall off screen
        }
    }
}



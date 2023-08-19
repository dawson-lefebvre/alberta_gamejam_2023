using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvanFishTest : MonoBehaviour
{
    [SerializeField] HingeJoint2D hinge;
    [SerializeField] KeyCode controlName;
    [SerializeField] float paddleSpeed;

    void Update()
    {
        Flip(Input.GetKey(controlName)); ;
    }

    public void Flip(bool isPressed)
    {
        hinge.useMotor = isPressed;
        Debug.Log("Wah");
    }
}
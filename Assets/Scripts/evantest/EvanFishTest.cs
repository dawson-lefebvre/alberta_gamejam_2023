using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvanFishTest : MonoBehaviour
{
    [SerializeField] HingeJoint2D hinge;
    [SerializeField] float flopSpeed;

    private void Start()
    {
        HingeJoint2D hinge = GetComponent<HingeJoint2D>();
        JointMotor2D motor = hinge.motor;
        motor.motorSpeed = flopSpeed;

        //hinge.motor.motorSpeed = flopSpeed; *ERROR*
    }

    public void Flip(bool isPressed)
    {
        hinge.useMotor = isPressed;
        Debug.Log("Wah");
    }
}
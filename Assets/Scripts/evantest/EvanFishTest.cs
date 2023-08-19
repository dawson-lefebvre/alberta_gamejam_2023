using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvanFishTest : MonoBehaviour
{
    [SerializeField] HingeJoint2D hinge;
    [SerializeField] float flopSpeed;
    JointMotor2D motor;

    private void Start()
    {
        motor = hinge.motor;
        motor.motorSpeed = flopSpeed;
        //hinge.motor.motorSpeed = flopSpeed; *ERROR*
    }

    public void Flip(float direction)
    {
        motor.motorSpeed *= Mathf.Round(direction);
        hinge.useMotor = (Mathf.Round(direction) != 0);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] EvanFishTest tailMove;
    [SerializeField] EvanFishTest headMove;

    //[SerializeField] Key useLeft;
    //[SerializeField] Key useRight;

    void Update()
    {
        headMove.Flip(Input.GetAxis("HeadFlop"));
        tailMove.Flip(Input.GetAxis("TailFlop"));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowBoxBehaviour : MonoBehaviour
{
    [SerializeField] GameObject MotherShip;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Cow")
        {
            MotherShip.GetComponent<MothershipFollow>().ThumbsUp();
        }
    }
}

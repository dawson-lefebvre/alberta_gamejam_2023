using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBehav : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Breaker")
        {
            //"Unlock" a bunch of broken pieces that lose all collision and fall off screen
        }
    }

    //Update, if y <-100 then disable

}

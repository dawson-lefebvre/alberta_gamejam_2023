using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarBehaviour : MonoBehaviour
{
    //ref to ufo pos
    //ref to slider image pos
    //
    //
    //our pos.y = camera.pos.y
    //slider.pos.y = this.pos
    //
    /*
     *  Ceil - Floor = bigDistTotal
        UFO - Floor = bifDistCurrent
        bigDistTotal / bigDistCurrent = bigDistRatio

        Bar.Top - Bar.Bottom = barRange
        SmallUFO.pos.x = bar.Bottom + (barRange x  bigDistRatio)
     */

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

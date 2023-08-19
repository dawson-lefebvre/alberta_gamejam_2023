using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class SplineTest : MonoBehaviour
{
    SpriteShapeController controller;
    Spline spline;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<SpriteShapeController>();
        spline = controller.spline;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(spline.GetRightTangent(0));
        if (Input.GetKey(KeyCode.W))
        {
            if(spline.GetRightTangent(0).y < 0.8f)
            {
                spline.SetRightTangent(0, new Vector3(0.6f, spline.GetRightTangent(0).y + 0.1f, 0));
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (spline.GetRightTangent(0).y > -0.8f)
            {
                spline.SetRightTangent(0, new Vector3(0.6f, spline.GetRightTangent(0).y - 0.1f, 0));
            }
        }
        else
        {
            //if (spline.GetRightTangent(0).y > 0)
            //{
            //    spline.SetRightTangent(0, new Vector3(0.6f, spline.GetRightTangent(0).y - 0.1f, 0));
            //}
            //else if (spline.GetRightTangent(0).y < 0)
            //{
            //    spline.SetRightTangent(0, new Vector3(0.6f, spline.GetRightTangent(0).y + 0.1f, 0));
            //}
            spline.SetRightTangent(0, new Vector3(0.6f, 0, 0));
        }

        if (Input.GetMouseButton(0))
        {
            if (spline.GetLeftTangent(1).y < 0.8f)
            {
                spline.SetLeftTangent(1, new Vector3(-0.6f, spline.GetLeftTangent(1).y + 0.1f, 0));
            }
        }
        else if (Input.GetMouseButton(1))
        {
            if (spline.GetLeftTangent(1).y > -0.8f)
            {
                spline.SetLeftTangent(1, new Vector3(-0.6f, spline.GetLeftTangent(1).y - 0.1f, 0));
            }
        }
        else
        {
            //if (spline.GetLeftTangent(1).y > 0)
            //{
            //    spline.SetLeftTangent(1, new Vector3(-0.6f, spline.GetLeftTangent(0).y - 0.1f, 0));
            //}
            //else if (spline.GetLeftTangent(1).y < 0)
            //{
            //    spline.SetLeftTangent(1, new Vector3(-0.6f, spline.GetLeftTangent(0).y + 0.1f, 0));
            //}
            spline.SetLeftTangent(1, new Vector3(-0.6f, 0, 0));
        }
    }
}

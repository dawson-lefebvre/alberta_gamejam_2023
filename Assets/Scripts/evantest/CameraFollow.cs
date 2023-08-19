using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject cameraObj;
    Camera cameraMain;
    Vector3 cameraPos;
    [SerializeField] Transform followTarget;
    [SerializeField] Transform CeilingObject; //These are empties marking the Y-coord that we dont want...
    [SerializeField] Transform FloorObject; //...the top of the frame to go above, or bottom below
    float Ceiling;
    float Floor;

    void Start()
    {
        cameraMain = cameraObj.GetComponent<Camera>();
        cameraPos = cameraObj.transform.position;
        Ceiling = CeilingObject.position.y;
        Floor = FloorObject.position.y;
    }

    void Update()
    {
        Vector2 targetPos = followTarget.position;

        //if (targetPos.y + cameraMain.orthographicSize! > Ceiling &&
        //    targetPos.y - cameraMain.orthographicSize !< Floor)
        //{
        //    cameraPos = targetPos;
        //}



        if (targetPos.y + cameraMain.orthographicSize <= Ceiling &&
            targetPos.y - cameraMain.orthographicSize >= Floor)
        {
            cameraObj.transform.position = new Vector3(cameraPos.x, targetPos.y, cameraPos.z);

            Debug.Log("WAHHH");
        }
        Debug.Log(cameraMain.orthographicSize);
        Debug.Log($"{Floor} .... {Ceiling}");

    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuBackgroundMove : MonoBehaviour
{
    public MeshRenderer mr;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mr.material.mainTextureOffset += new Vector2(0, speed * Time.deltaTime);
    }
}

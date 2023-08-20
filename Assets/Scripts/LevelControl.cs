using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Globals.cowsRemaining = 20; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Globals.cowsRemaining == 0) 
        {
            SceneManager.LoadScene(0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CowsRemainingScript : MonoBehaviour
{
    TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = $"Cows Remaining: {Globals.cowsRemaining}";
    }
}

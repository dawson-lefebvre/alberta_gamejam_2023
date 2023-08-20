using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBar : MonoBehaviour
{
    RectTransform rect;
    [SerializeField] GameObject UFO;
    public float lowestUIPoint;
    public float highestUIPoint;
    public float lowestPlayerPoint;
    public float highestPlayerPoint;
    float uiLength;
    float playerLength;
    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();
        uiLength = highestUIPoint - lowestUIPoint;
        playerLength = highestPlayerPoint - lowestPlayerPoint;
    }

    // Update is called once per frame
    void Update()
    {
        float currentPlayerLength = UFO.transform.position.y - lowestPlayerPoint;
        float percentCompete = currentPlayerLength / playerLength;

        Debug.Log(percentCompete);
        rect.transform.localPosition = new Vector3(rect.transform.localPosition.x, (percentCompete * uiLength) + lowestUIPoint, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBar : MonoBehaviour
{
    RectTransform rect; //To access position of the progress bar UFO
    [SerializeField] GameObject UFO; //To access the position of the player UFO
    public float lowestUIPoint; //Lowest point of the progress UFO
    public float highestUIPoint;
    public float lowestPlayerPoint; //Lowest point of the player
    public float highestPlayerPoint;
    float uiLength; //Total units the progress bar can move
    float playerLength; //Total units the player will move in game
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
        float currentPlayerLength = UFO.transform.position.y - lowestPlayerPoint; //Where the player is in relation to the bottom
        float percentCompete = currentPlayerLength / playerLength; //Finds the percentage of the y position (1 being the highest position)

        rect.transform.localPosition = new Vector3(rect.transform.localPosition.x, (percentCompete * uiLength) + lowestUIPoint, 0); //Takes the percentage and applies it to the progress bar so it moves relative to the player
    }
}

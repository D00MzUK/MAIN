/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public Text textPoints;

    public int startPoints = 50;
    public int multiplier = 1;
    public int totalPoints = 0;

    void Start()
    {
        textPoints = GetComponent<Text>;
    }

    void Update()
    {
        textPoints.Text = "Points: " + totalPoints;
    }

    IEnumerator MultiplyPoints()
    {
        yield return new WaitForSeconds(30);
        totalPoints += startPoints * multiplier;
        multiplier++;
    }
}*/

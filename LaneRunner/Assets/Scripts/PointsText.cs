using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsText : MonoBehaviour
{
    public GameObject player;
    public Text pointsText;
    public float points;
    
    private void Start()
    {
        points = player.GetComponent<ManagerGlobal>().PointsCounter;
    }

    // Update is called once per frame
    void Update()
    {
        points = player.GetComponent<ManagerGlobal>().PointsCounter;
        pointsText.text = "Points: " + points;
    }
}
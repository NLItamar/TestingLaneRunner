using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsManager : MonoBehaviour
{
    public GameObject Points;

    //invoke spawning lanes every x seconds on x lane
    void Start()
    {
        InvokeRepeating("SpawnPointsMiddle", 0, 6);
        InvokeRepeating("SpawnPointsLeft", 2, 6);
        InvokeRepeating("SpawnPointsRight", 4, 6);
    }

    //spawning le points
    void SpawnPointsMiddle()
    {
        Instantiate(Points, new Vector3(0f, 0.2f, 30f), Quaternion.identity);
        Instantiate(Points, new Vector3(0f, 0.2f, 30.5f), Quaternion.identity);
        Instantiate(Points, new Vector3(0f, 0.2f, 31f), Quaternion.identity);
        Instantiate(Points, new Vector3(0f, 0.2f, 31.5f), Quaternion.identity);
        Instantiate(Points, new Vector3(0f, 0.2f, 32f), Quaternion.identity);
    }

    void SpawnPointsLeft()
    {
        Instantiate(Points, new Vector3(1f, 0.2f, 30f), Quaternion.identity);
        Instantiate(Points, new Vector3(1f, 0.2f, 30.5f), Quaternion.identity);
        Instantiate(Points, new Vector3(1f, 0.2f, 31f), Quaternion.identity);
        Instantiate(Points, new Vector3(1f, 0.2f, 31.5f), Quaternion.identity);
        Instantiate(Points, new Vector3(1f, 0.2f, 32f), Quaternion.identity);
    }

    void SpawnPointsRight()
    {
        Instantiate(Points, new Vector3(-1f, 0.2f, 30f), Quaternion.identity);
        Instantiate(Points, new Vector3(-1f, 0.2f, 30.5f), Quaternion.identity);
        Instantiate(Points, new Vector3(-1f, 0.2f, 31f), Quaternion.identity);
        Instantiate(Points, new Vector3(-1f, 0.2f, 31.5f), Quaternion.identity);
        Instantiate(Points, new Vector3(-1f, 0.2f, 32f), Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningEnemies : MonoBehaviour
{
    public GameObject SimpleEnemy;

    //invoke spawning lanes every x seconds on x lane
    void Start()
    {
        InvokeRepeating("SpawnPointsMiddle", 12, 6);
        InvokeRepeating("SpawnPointsLeft", 15, 8);
        InvokeRepeating("SpawnPointsRight", 18, 10);
    }

    //spawning le points
    void SpawnPointsMiddle()
    {
        Instantiate(SimpleEnemy, new Vector3(0f, 0.23f, 30f), Quaternion.identity);

    }

    void SpawnPointsLeft()
    {
        Instantiate(SimpleEnemy, new Vector3(1f, 0.23f, 30f), Quaternion.identity);
    }

    void SpawnPointsRight()
    {
        Instantiate(SimpleEnemy, new Vector3(-1f, 0.23f, 30f), Quaternion.identity);
    }
}

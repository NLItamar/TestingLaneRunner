using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningEnemies : MonoBehaviour
{
    public GameObject SimpleEnemy;

    //invoke spawning lanes every x seconds on x lane
    void Start()
    {
        InvokeRepeating("SpawnPointsMiddle", 4, 6);
        InvokeRepeating("SpawnPointsLeft", 6, 6);
        InvokeRepeating("SpawnPointsRight", 2, 6);
        InvokeRepeating("SpawnMoreRandomlyIsh", 15, 15);
    }

    //spawning le points
    public GameObject SpawnPointsMiddle()
    {
        Instantiate(SimpleEnemy, new Vector3(0f, 0.23f, 30f), Quaternion.identity);
        return SimpleEnemy;
    }

    public GameObject SpawnPointsLeft()
    {
        Instantiate(SimpleEnemy, new Vector3(1f, 0.23f, 30f), Quaternion.identity);
        return SimpleEnemy;
    }

    public GameObject SpawnPointsRight()
    {
        Instantiate(SimpleEnemy, new Vector3(-1f, 0.23f, 30f), Quaternion.identity);
        return SimpleEnemy;
    }

    public void SpawnMoreRandomlyIsh()
    {
        Instantiate(SimpleEnemy, new Vector3(0f, 0.23f, 35f), Quaternion.identity);
        Instantiate(SimpleEnemy, new Vector3(1f, 0.23f, 30f), Quaternion.identity);
        Instantiate(SimpleEnemy, new Vector3(-1f, 0.23f, 40f), Quaternion.identity);
    }
}

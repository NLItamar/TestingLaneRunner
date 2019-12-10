using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnThaBalls : MonoBehaviour
{
    public GameObject Balls;

    //invoke spawning lanes every x seconds on x lane
    void Start()
    {
        InvokeRepeating("SpawnBalls", 0.2f, 0.2f);
    }

    void SpawnBalls()
    {
        Instantiate(Balls, new Vector3(0, 0, 60), Quaternion.identity);
    }
}

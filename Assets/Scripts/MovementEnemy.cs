﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEnemy : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        EnemyMoving();
    }

    void EnemyMoving()
    {
        Vector3 position = this.transform.position;
        position.z = position.z - 0.3f;
        this.transform.position = position;
    }
}

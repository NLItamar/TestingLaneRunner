using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEnemy : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 position = this.transform.position;
        position.z = position.z - 0.1f;
        this.transform.position = position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingTubeThings : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, -40) * Time.deltaTime);

        Vector3 position = this.transform.position;
        position.z = position.z - 0.3f;
        this.transform.position = position;


    }
}

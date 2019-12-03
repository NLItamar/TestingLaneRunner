using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public float PointsCounter = 0;

    //collision
    void OnTriggerEnter(Collider otherobject)
    {
        if(otherobject.gameObject.tag == "Points")
        {
            PointsCounter++;
            Destroy(otherobject.gameObject);
        }
    }
}

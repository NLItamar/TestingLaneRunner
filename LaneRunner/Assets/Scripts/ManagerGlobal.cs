using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerGlobal : MonoBehaviour
{
    public float PointsCounter = 0;
    public float Lives = 3;

    //collision and adding points
    void OnTriggerEnter(Collider otherobject)
    {
        if(otherobject.gameObject.tag == "Points")
        {
            PointsCounter++;
            Destroy(otherobject.gameObject);
        }
        if(otherobject.gameObject.tag == "EnemySimple")
        {
            Lives--;
            Destroy(otherobject.gameObject);
        }
    }
}

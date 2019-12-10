using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZoneManager : MonoBehaviour
{
    void OnTriggerEnter(Collider otherobject)
    {
        if (otherobject.gameObject.tag == "Points")
        {
            Destroy(otherobject.gameObject);
        }
        if (otherobject.gameObject.tag == "EnemySimple")
        {
            Destroy(otherobject.gameObject);
        }
        if(otherobject.gameObject.tag == "RotatingBalls")
        {
            Destroy(otherobject.gameObject);
        }
    }
}

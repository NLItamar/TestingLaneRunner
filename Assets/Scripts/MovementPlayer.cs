using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MovementPlayer : MonoBehaviour
{
    void Update()
    {
        //movement
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }

        //clamping the player
        Vector3 currentPosition = transform.position;
        currentPosition.x = Mathf.Clamp(transform.position.x, -1.0f, 1.0f);
        transform.position = currentPosition;
    }
}
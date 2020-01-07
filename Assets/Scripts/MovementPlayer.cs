using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MovementPlayer : MonoBehaviour
{
    //to-do lerp movement
    public bool playerIsMoving = false;
    public bool playerIsClamped = false;

    void Update()
    {
        //movement
        Movement();
        ClampPlayer();
    }

    void PlayerSmoothMovement()
    {
        //to-do lerp movement
    }


    void Movement()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A) && playerIsMoving == false)
        {
            playerIsMoving = true;
            PlayerMovementLeft();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D) && playerIsMoving == false)
        {
            playerIsMoving = true;
            PlayerMovementRight();
        }
    }

    void PlayerMovementLeft()
    {
        Vector3 position = this.transform.position;
        position.x--;
        this.transform.position = position;
        playerIsMoving = false;
    }

    void PlayerMovementRight()
    {
        Vector3 position = this.transform.position;
        position.x++;
        this.transform.position = position;
        playerIsMoving = false;
    }

    void ClampPlayer()
    {
        //clamping the player
        Vector3 currentPosition = transform.position;
        currentPosition.x = Mathf.Clamp(transform.position.x, -1.0f, 1.0f);
        transform.position = currentPosition;
        playerIsClamped = true;
    }
}
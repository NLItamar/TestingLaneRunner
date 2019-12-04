using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesText : MonoBehaviour
{
    public GameObject player;
    public Text livesText;
    public float lives;

    private void Start()
    {
        lives = player.GetComponent<ManagerGlobal>().Lives;
    }

    // Update is called once per frame
    void Update()
    {
        lives = player.GetComponent<ManagerGlobal>().Lives;
        livesText.text = "Lives: " + lives;
    }
}
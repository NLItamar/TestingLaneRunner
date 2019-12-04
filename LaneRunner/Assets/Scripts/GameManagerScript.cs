using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManagerScript : MonoBehaviour
{
    public GameObject player;
    public GameObject gameOver;

    // Update is called once per frame
    void Update()
    {
        if(player.GetComponent<ManagerGlobal>().Lives <= 0)
        {
            gameOver.SetActive(true);
            Invoke("GameOver", 3);
        }
    }

    void GameOver()
    {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Game_Manager : MonoBehaviour
{

    public GameObject gameOverCanvas;

    public  void Start()
    {

        Time.timeScale = 1;
        gameOverCanvas.SetActive(false);

    }

    public void GameOver()
    {    
            gameOverCanvas.SetActive(true);
            Time.timeScale = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

}

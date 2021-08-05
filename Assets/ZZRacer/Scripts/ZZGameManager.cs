using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZZGameManager : MonoBehaviour
{
     
    public static ZZGameManager Instance;
    public bool gameStarted = false;
    private bool isGameOver = false;

    public GameObject platformSpwaner;



    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
    }

    void Update()
    { 
        if(!gameStarted)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameStarted();
            }
        }
    }

    void GameStarted()
    {
        isGameOver = false;
        gameStarted = true;
        platformSpwaner.SetActive(true);

        if (GameObject.FindObjectOfType<ZZScoreManager>() != null)
            GameObject.FindObjectOfType<ZZScoreManager>().ScoreStarted();
    }

    public void GameOver()
    {
        if (isGameOver)
            return;

        isGameOver = true;
        platformSpwaner.SetActive(false);

        if (GameObject.FindObjectOfType<ZZScoreManager>() != null)
            GameObject.FindObjectOfType<ZZScoreManager>().ScoreStoped();


        Invoke("GameOverGameUI", 0.5f); // Reload Game
    }


    void GameOverGameUI()
    {
        if (GameObject.FindObjectOfType<GameOverUI>() != null)
            GameObject.FindObjectOfType<GameOverUI>().Setup();
    }

}

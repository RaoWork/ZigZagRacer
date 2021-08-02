using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZZGameManager : MonoBehaviour
{
     
    public static ZZGameManager Instance;
    public bool gameStarted = false;

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
        gameStarted = true;
        platformSpwaner.SetActive(true);


        GameObject.FindObjectOfType<ZZScoreManager>().ScoreAdd();
    }

    public void GameOver()
    {
        platformSpwaner.SetActive(false);
        GameObject.FindObjectOfType<ZZScoreManager>().ScoreStop();

        // Reload 
        Invoke("ReloadGame", 1f);
    }


    void ReloadGame()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
    }
}

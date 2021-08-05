using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{

    [SerializeField] private Text scoreTxt;
    [SerializeField] private Text bestScoreTxt;


    void Start()
    { 
    }

    private void OnEnable()
    {
        Show(false);
    }

    public void Setup()
    {
        Show(true);
        SoundGameOver();    // Sound play
        ScoreDisplayUI();
    }

    void Show(bool _enable)
    {
        transform.Find("GameOver").gameObject.SetActive(_enable);
    }

    void SoundGameOver()
    {
        if (GameObject.FindObjectOfType<SoundManager>() != null)
            GameObject.FindObjectOfType<SoundManager>().GameOverPlay();
    }

    void ScoreDisplayUI()
    {
        if (GameObject.FindObjectOfType<ZZScoreManager>() == null)
            return;

        scoreTxt.text = GameObject.FindObjectOfType<ZZScoreManager>().zzScore.GetScore().ToString();
    }
}

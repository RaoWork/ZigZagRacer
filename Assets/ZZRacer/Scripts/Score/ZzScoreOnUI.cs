using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ZzScoreOnUI : MonoBehaviour
{

    ZZScoreManager zzScoreManager;
    [SerializeField] private Text scoreTxt;
  

    private void OnEnable()
    {
        zzScoreManager = GameObject.FindObjectOfType<ZZScoreManager>();
        ZzScore.onScoreAmountUpdate += ScoreUpdateUI; //Add Event register
    }

    private void OnDisable()
    {
        ZzScore.onScoreAmountUpdate -= ScoreUpdateUI; //Remove Event register
    }


    void ScoreUpdateUI(object onj, EventArgs arg)
    {
        scoreTxt.text = zzScoreManager.zzScore.GetScore().ToString();
    }
}

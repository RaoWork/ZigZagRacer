using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SoundClicked : MonoBehaviour
{

    private Button btn;


    private void OnEnable()
    {
        Clicked();
    }

    private void Clicked()
    {
        btn = GetComponent<Button>();

        btn.onClick.AddListener(() =>
        {
            if (GameObject.FindObjectOfType<SoundManager>() == null)
                return;

            SoundManager soundManager = GameObject.FindObjectOfType<SoundManager>();
            soundManager.ClickedPlay();
        });
    }
}

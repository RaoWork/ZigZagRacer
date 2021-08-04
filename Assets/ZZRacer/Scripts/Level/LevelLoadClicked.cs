using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelLoadClicked : MonoBehaviour
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
            if (GameObject.FindObjectOfType<LevelController>() == null)
                return;

            LevelController levelController = GameObject.FindObjectOfType<LevelController>();
            levelController.LoadLevel();
        });
    }
}

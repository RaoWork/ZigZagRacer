using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelLoadClicked : MonoBehaviour
{

    public LevelLoader.SceneName levelName;
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
            SelectedLoadLevel();
        });
    }

    void SelectedLoadLevel()
    {
        if (GameObject.FindObjectOfType<LevelController>() == null)
            return;

        LevelController levelController = GameObject.FindObjectOfType<LevelController>();

        switch (levelName)
        {
            case LevelLoader.SceneName.None:
                levelController.LoadLevel();
                break;
            default:
                levelController.LoadLevel(levelName);
                break;
        }
    }
}

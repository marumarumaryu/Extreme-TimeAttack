using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartSclipt : MonoBehaviour
{
    Button btn;

    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(gameStart);
    }

    void Update()
    {
        if (StageSelect.stageNamber >= 1)
        {
            btn.interactable = true;
        }
        else
        {
            btn.interactable = false;
        }
    }

    private void gameStart()
    {
        SceneManager.LoadScene("MountainTrack");
    }
}

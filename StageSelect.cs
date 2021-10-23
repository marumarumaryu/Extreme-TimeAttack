using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{

    [SerializeField] private GameObject startGame;
    public static int stageNamber = 0;

    public void cLoseStageSelect()
    {
        startGame.SetActive(false);
        stageNamber = 0;
    }

    public void stage1()
    {
        stageNamber = 1;
    }

    public void stage2()
    {
        stageNamber = 2;
    }
}

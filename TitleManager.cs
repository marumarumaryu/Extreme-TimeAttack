using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("MountainTrack");
    }

    public void endGame()
    {
        Application.Quit();
        Debug.Log("END");
    }
}

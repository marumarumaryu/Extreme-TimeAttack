using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    void Start()
    {
        GameObject car = GameObject.Find("Car");
        GameObject sporn1 = GameObject.Find("Sporn1");
        GameObject sporn2 = GameObject.Find("Sporn2");

        if (StageSelect.stageNamber == 1)
        {
            car.transform.position = sporn1.transform.position;
            car.transform.rotation = sporn1.transform.rotation;
        }
        else if (StageSelect.stageNamber == 2)
        {
            car.transform.position = sporn2.transform.position;
            car.transform.rotation = sporn2.transform.rotation;
        }
        
        Time.timeScale = 1f;
        AudioListener.volume = TitleManager.masterVolume / 100f;

    }

    public void gameRestart()
    {
        SceneManager.LoadScene("MountainTrack");
    }

    public void topMenue()
    {
        SceneManager.LoadScene("Title");
    }
}

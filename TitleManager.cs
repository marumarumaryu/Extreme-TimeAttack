using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleManager : MonoBehaviour
{
    
    [SerializeField] private GameObject OputionUi;
    [SerializeField] private GameObject startGame;
    public Text volumeLevel;
    public static float masterVolume = 100;

    public void stageSelect()
    {
        startGame.SetActive(true);
        //SceneManager.LoadScene("MountainTrack");
    }

    public void endGame()
    {
        Application.Quit();
        Debug.Log("END");
    }

    public void openOption()
    {
        OputionUi.SetActive(true);
        displayVolumLevel();
    }

    public void cLoseOption()
    {
        OputionUi.SetActive(false);
    }

    public void SoundSliderOnValueChange(float newSliderValue)
    {
        masterVolume = newSliderValue;
        AudioListener.volume = masterVolume/ 100f;
        displayVolumLevel();
    }

    void displayVolumLevel()
    {
        volumeLevel.text = masterVolume.ToString("F0") + ("%");
    }
}

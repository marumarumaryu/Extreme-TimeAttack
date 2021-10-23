//全て自分で書いた
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LaptimeSystem : MonoBehaviour
{

    public Text timeText;
    public SoundEffect SE;

    private float minutes, countTime;
    private int LapCheck, sectorCheck, a, b;
    private bool c;

    private void Start()
    {
        LapCheck = 0;
        sectorCheck = 0;
        a = 0;
        b = 0;
        c = false;
    }

    private void Update()
    {
        timer();
        if (b == 0)
        {
            timeText.text = minutes.ToString("0") + "'" + countTime.ToString("00.000");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ControlLine"))
        {
            a = 1;
            if (LapCheck >= 18)
            {
                countTime = 0;
                LapCheck = 0;
                minutes = 0;
                sectorPasscheck();
            }
        }
        else if (other.CompareTag("Sector"))
        {
            sectorPasscheck();
            lapPasscheck();
        }
        else if (other.CompareTag("Checkpoint"))
        {
            sectorCheck++;
            c = false;
            lapPasscheck();
        }
    }

    void timer()
    {
        if (a == 1)
        {
            countTime += Time.deltaTime;
        }
        if (countTime >= 60)
        {
            minutes++;
            countTime -= 60;
        }       
    }

    void sectorPasscheck()
    {
        if (sectorCheck >= 1)
        {
            b++;
            sound();
            Invoke("reset", 3);
        }
    } 

    void lapPasscheck()
    {
        LapCheck++;
    }

    void reset()
    {
        b = 0;
    }

    void sound()
    {
        if (!c)
        {
            SE.soundSE01();
            c = true;
            //なぜか3回OnTriggerEnterが反応するため、bool変数を使ってゴリ押した。
            //あとで原因究明する
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using TMPro;
using System;

public class TimerController : MonoBehaviour
{
    Stopwatch watch = new Stopwatch();
    private bool StartTime = false;

    [SerializeField] private TMP_Text timerText;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(StartTime)
            timerText.text = (watch.Elapsed.Seconds + watch.Elapsed.Minutes*60) + ":" + watch.Elapsed.Milliseconds/10 + "s";
    }

    public void StartTimer()
    {
        watch.Start();
        StartTime = true;
    }

    public void StopTimer()
    {
        watch.Stop();
        StartTime = false;
    }

}

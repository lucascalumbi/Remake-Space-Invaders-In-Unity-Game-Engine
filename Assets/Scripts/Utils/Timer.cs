using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{   
    [SerializeField] private float timer;
    [SerializeField] [ReadOnly] private float runningTimer;
    [SerializeField] [ReadOnly] private Boolean isRunning;
    [SerializeField] [ReadOnly] private Boolean isOver;

    void Start()
    {
        Reset();
    }
    void FixedUpdate()
    {   
        if(isOver) return;

        if(!isRunning) return;

        runningTimer -= Time.fixedDeltaTime;
        isOver = runningTimer <= 0;
        
        if(isOver) Pause();
    }

    public void SetTimer(float timer)
    {
        this.timer = timer;
    }
    public float GetTimer()
    {
        return timer;
    }
    public void Run()
    {
        isRunning = true;
    }
    public void Pause()
    {
        isRunning = false;
    }
    public void Reset()
    {
        runningTimer = timer;
        isRunning = false;
        isOver = false;
    }
    public void ResetAndRun()
    {
        Reset();
        Run();
    }
    public Boolean IsRunning()
    {
        return isRunning;
    }
    public Boolean IsOver()
    {
        return isOver;
    }
}

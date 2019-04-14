﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GVRbutton : MonoBehaviour
{
    public Image imgCircle;
    public UnityEvent GVRClick;
    public float totalTime = 2;
    public bool gvrStatus;
    public float gvrTimer;

    public bool hit = false;

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgCircle.fillAmount = gvrTimer / totalTime;
        }
        if (gvrTimer > totalTime)
        {
            if(!hit) 
            {
                hit = true;
                GVRClick.Invoke();
            }

        }
    }
    public void GvrOn()
    {
        gvrStatus = true;
    }
    public void gvrOff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgCircle.fillAmount = 0;
        hit = false;
    }
}

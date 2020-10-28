using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AutoPlay : MonoBehaviour
{
    [SerializeField] bool autoPlay;
    [SerializeField] private TextMeshProUGUI AutoPlayText;
    public void AutoPlayOnOff()
    {
        if (autoPlay == false )
        {
            autoPlay = true;
            AutoPlayText.text = "On";
        }
        else if(autoPlay == true )
        {
            autoPlay = false;
            AutoPlayText.text = "Off";
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AutoPlayOnOff();
        }
    }

    public bool IsAutoPlayEnabled()
    {
        return autoPlay;
    }
}

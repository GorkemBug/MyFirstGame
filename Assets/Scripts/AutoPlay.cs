using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AutoPlay : MonoBehaviour
{
    [SerializeField] Boolean autoPlay;
    [SerializeField] private TextMeshProUGUI AutoPlayText;
    public void AutoPlayOnOff()
    {
        autoPlay = !autoPlay;
        AutoPlayText.text = autoPlay.Equals(true) ? "On" : "Off";
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

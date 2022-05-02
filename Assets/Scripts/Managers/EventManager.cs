using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void OnClick();
    public static event OnClick click;

    void OnEvent()
    {
        if (click != null)
        {
            click();
        }
    }

}

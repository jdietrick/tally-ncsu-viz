﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventTriggerTest : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            EventManager.TriggerEvent("test");
        }

        if (Input.GetKeyDown("o"))
        {
            EventManager.TriggerEvent("Spawn");
        }

        if (Input.GetKeyDown("p"))
        {
            EventManager.TriggerEvent("Destroy");
        }
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ShutDownGame : MonoBehaviour
{
    public void ShutDown()
    {
        Application.Quit();
    }
}

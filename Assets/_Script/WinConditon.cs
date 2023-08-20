using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinConditon : MonoBehaviour
{
    private PlatformGenerator _platformGenerator;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit");
    }
}

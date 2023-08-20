using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class PlatformGenerator : MonoBehaviour
{
    [SerializeField] GameObject platforms;
    [SerializeField] float heights;
    [SerializeField] float maxTime;
    private float timer;


    private void Start()
    {
        GeneratePlatform();
    }

    private void Update()
    {
        if (timer > maxTime)
        {
            GeneratePlatform();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    void GeneratePlatform()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-heights, heights));
        GameObject pipe = Instantiate(platforms, spawnPos, Quaternion.identity);
        Destroy(pipe, 20f);
    }

    
}

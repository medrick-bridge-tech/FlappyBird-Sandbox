using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    void Update()
    {
        transform.position += Vector3.right * moveSpeed *Time.deltaTime;
    }
}

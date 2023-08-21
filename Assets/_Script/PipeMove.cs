using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PipeMove : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    private float score;
    void Update()
    {
        transform.position += Vector3.right * moveSpeed *Time.deltaTime;
    }

    
    
        
        
    
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rbPlayer;
    [SerializeField] float jumpForcce;
    private float score;

    void Start()
    {
        _rbPlayer = GetComponent<Rigidbody2D>();
        
    }

     void Update()
    {
        JumpAndForward();
        
    }

    void JumpAndForward()
    {
        Vector2 jump = Vector2.up * jumpForcce;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rbPlayer.AddForce(jump, ForceMode2D.Impulse);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Pipe")
        {
            Debug.Log(++score);
        }
    }
}

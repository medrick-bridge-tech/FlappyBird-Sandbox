using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rbPlayer;
    private bool isJumping = true;
    private bool isKeyPressed = false;
    [SerializeField] float jumpForcce;
    [SerializeField] float forwardForce;

    void Start()
    {
        _rbPlayer = GetComponent<Rigidbody2D>();
        
    }

     void Update()
    {
        Jump();
        MoveForward();
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rbPlayer.AddForce(Vector2.up * jumpForcce, ForceMode2D.Impulse);
            isJumping = false;
        }
    }

    void MoveForward()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rbPlayer.AddForce(Vector2.right * forwardForce,ForceMode2D.Impulse);
        }
    }
}

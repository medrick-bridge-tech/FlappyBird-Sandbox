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
    private float reset = 0;

    void Start()
    {
        _rbPlayer = GetComponent<Rigidbody2D>();
    }

     void Update()
    {
       
        Jump();
        
    }

    void Jump()
    {
        Vector3 jump = Vector3.up * jumpForcce;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rbPlayer.velocity = new Vector2(_rbPlayer.velocity.x, 0);
            _rbPlayer.AddForce(jump , ForceMode2D.Impulse);
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

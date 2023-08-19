using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Camera _camera;
    [SerializeField] private GameObject obj;
    void Start()
    {
        _camera = GetComponent<Camera>();
        
    }
    void Update()
    {
        Follow();
    }

    void Follow()
    {
        var position = obj.transform.position;
        _camera.transform.position = new Vector3(position.x,0, -10);
    }
}

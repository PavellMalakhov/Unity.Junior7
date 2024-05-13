using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementForward : MonoBehaviour
{
    [SerializeField] private Vector3 _direction = Vector3.forward;
    [SerializeField] private float _speedMove = 1f;
    
    private void Update()
    {
        transform.Translate(_direction * _speedMove * Time.deltaTime, Space.Self);
    }
}

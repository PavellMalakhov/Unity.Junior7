using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAround : MonoBehaviour
{
    [SerializeField] private float _speedRotation = 90f;

    private void Update()
    {
        transform.Rotate(transform.up, _speedRotation * Time.deltaTime);
    }
}

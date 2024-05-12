using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Growth : MonoBehaviour
{
    [SerializeField] private float _speedGrowth = 0.1f;

    void Update()
    {
        var size = _speedGrowth * Time.deltaTime;

        transform.localScale += new Vector3(size, size, size);
    }
}

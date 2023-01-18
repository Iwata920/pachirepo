using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartsSpin : MonoBehaviour
{
    [SerializeField] private float _XSpinSpeed;
    [SerializeField] private float _YSpinSpeed;
    [SerializeField] private float _ZSpinSpeed;

    private void Update()
    {
        transform.Rotate(Time.deltaTime * _XSpinSpeed, Time.deltaTime * _YSpinSpeed, Time.deltaTime * _ZSpinSpeed);
    }
}

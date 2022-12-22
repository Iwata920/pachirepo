using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartsSpin : MonoBehaviour
{
    [SerializeField] private float _YSpinSpeed;
    [SerializeField] private float _ZSpinSpeed;
    private void Start()
    {
        
    }
    private void Update()
    {
        transform.Rotate(0, Time.deltaTime * _YSpinSpeed, Time.deltaTime * _ZSpinSpeed);
    }
}

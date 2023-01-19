using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartsSpin : MonoBehaviour
{
    [SerializeField] private float _ZSpinSpeed;

    private void Update()
    {
        transform.Rotate(Time.deltaTime * 0, Time.deltaTime * 0, Time.deltaTime * _ZSpinSpeed);
    }
}

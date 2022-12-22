using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartsMove : MonoBehaviour
{
    private Vector3 _PartsPos;
    [SerializeField] private float _xMoveDistance;
    [SerializeField] private float _yMoveDistance;
    [SerializeField] private float _zMoveDistance;
    [SerializeField] private float _xMoveSpeed;
    [SerializeField] private float _yMoveSpeed;
    [SerializeField] private float _zMoveSpeed;

    private void Start()
    {
        _PartsPos = transform.position;
    }
    private void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time * _xMoveSpeed) * _xMoveDistance + _PartsPos.x, Mathf.Sin(Time.time * _yMoveSpeed) * _yMoveDistance + _PartsPos.y, Mathf.Sin(Time.time * _zMoveSpeed) * _zMoveDistance + _PartsPos.z);
    }
}

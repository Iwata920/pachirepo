using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceralationArea : MonoBehaviour
{
    [SerializeField] private float xSpeed = 5f;
    [SerializeField] private float ySpeed = 5f;
    [SerializeField] private float zSpeed = 5f;

    private void OnTriggerEnter(Collider other)
    {
        other.transform.GetComponent<Rigidbody>().velocity += new Vector3(xSpeed, ySpeed, zSpeed);
    }
}

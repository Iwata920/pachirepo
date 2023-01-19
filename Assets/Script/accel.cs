using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accel : MonoBehaviour
{
    [SerializeField]
    private float zSpeed = 5f;

    private bool isAccel = true;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "start" && isAccel == true)
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            Vector3 accel = new Vector3(0.0f, 0.0f, -zSpeed);
            rb.AddForce(accel * 1, ForceMode.Impulse);
            isAccel = false;
        }
    }
}

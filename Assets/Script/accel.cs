using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accel : MonoBehaviour
{
    [SerializeField]
    private float xSpeed = 5f;

    private bool isAccel = true;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "start" && isAccel == true)
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            Vector3 accel = new Vector3(xSpeed, 0.0f, 0.0f);
            rb.AddForce(accel * 1, ForceMode.Impulse);
            isAccel = false;
        }
    }
}

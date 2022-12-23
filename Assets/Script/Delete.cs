using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    private GameObject Obj;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            Obj = other.gameObject;
            Obj.SetActive(false);
        }
    }
}

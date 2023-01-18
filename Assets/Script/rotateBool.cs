using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateBool : MonoBehaviour
{
    private GameObject Obj;
    private Rotate flag;

    void Start()
    {
        flag = GetComponentInParent<Rotate>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            Obj = other.gameObject;
            Obj.SetActive(false);
            flag.isEnter = true;
        }
    }
}

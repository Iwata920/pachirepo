using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
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
            flag.isEnter = false;
            Obj = other.gameObject;
            Obj.SetActive(false);
        }
    }
}

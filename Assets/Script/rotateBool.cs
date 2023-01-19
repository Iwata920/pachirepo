using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateBool : MonoBehaviour
{
    [SerializeField]
    private GameObject hantei;
    private GameObject Obj;
    Rotate rotate;

    void Start()
    {
        rotate = hantei.GetComponent<Rotate>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            Obj = other.gameObject;
            Obj.SetActive(false);
            rotate.isEnter = true;
        }
    }
}

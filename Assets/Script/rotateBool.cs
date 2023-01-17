using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateBool : MonoBehaviour
{
    public bool isRotate = false;
    private GameObject Obj;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            isRotate = true;
            StartCoroutine("Timer");
            Obj = other.gameObject;
            Obj.SetActive(false);
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1.0f);
        isRotate = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atarime : MonoBehaviour
{
    private GameObject Obj;
    public bool Atari;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Atari = true;
            Obj = other.gameObject;
            Obj.SetActive(false);
            Debug.Log("V");
        }
    }
}

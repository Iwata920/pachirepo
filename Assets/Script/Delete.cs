using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    private GameObject Obj;
    public bool ishazure = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            ishazure = true;
            Obj = other.gameObject;
            Obj.SetActive(false);
            StartCoroutine("Timer");
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2.3f);
        ishazure = false;
    }
}

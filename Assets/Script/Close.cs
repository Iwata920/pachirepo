using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour
{
    private bool isClose = true;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball" && isClose == true)
        {
            animator.SetTrigger("close");
            isClose = false;
        }
    }
}

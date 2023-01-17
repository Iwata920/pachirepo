using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour
{
    [SerializeField]
    private GameObject delete;
    [SerializeField]
    private GameObject hantei;
    private bool isClose = true;
    Animator animator;
    Delete hazure;

    // Start is called before the first frame update
    void Start()
    {
        hazure = delete.GetComponent<Delete>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball" && isClose == true)
        {
            animator.SetTrigger("close");
            isClose = false;
            hantei.SetActive(false);
        }
    }

    void Update()
    {
        if (hazure.ishazure == true)
        {
            StartCoroutine("Timer");
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2.3f);
        animator.SetTrigger("open");
        isClose = true;
        hantei.SetActive(true);
    }
}

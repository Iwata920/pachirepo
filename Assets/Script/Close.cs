using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour
{
    [SerializeField]
    private GameObject hantei;
    private GameObject ballhantei;
    Animator animator;
    Rotate open;

    // Start is called before the first frame update
    void Start()
    {
        open = hantei.GetComponent<Rotate>();
        ballhantei = transform.GetChild(0).gameObject;
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball" && open.isEnter == true)
        {
            animator.SetBool("close", true);
            ballhantei.SetActive(false);
        }
    }

    void Update()
    {
        if(open.isEnter == false)
        {
            StartCoroutine("Timer");
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2.3f);
        animator.SetBool("close", false);
        ballhantei.SetActive(true);
    }
}

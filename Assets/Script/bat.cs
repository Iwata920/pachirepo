using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bat : MonoBehaviour
{
    [SerializeField]
    private GameObject hantei;
    [SerializeField]
    private GameObject yakyuuban;

    private bool isTimer = true;
    Rotate rotate;
    rotateAnim rotateanim;
    Animator animator;

    void Start()
    {
        rotate = hantei.GetComponent<Rotate>();
        rotateanim = yakyuuban.GetComponent<rotateAnim>();
        this.animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (rotate.isEnter == true)
        {
            animator.SetBool("stay", false);
        }
        if (rotateanim.isAnimend == true)
        {
            animator.SetBool("stance", true);

            if (Input.GetKeyDown(KeyCode.B))
            {
                animator.SetTrigger("bat");
                isTimer = false;
                StartCoroutine("Timer");
            }
        }
        if (rotate.isEnter == false)
        {
            animator.SetBool("stance", false);
            animator.SetBool("stay", true);
        }
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Ball" && isTimer == true)
    //    {
    //        animator.SetTrigger("bat");
    //        isTimer = false;
    //        StartCoroutine("Timer");
    //    }
    //}

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1.0f);
        isTimer = true;
    }
}

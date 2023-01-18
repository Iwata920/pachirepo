using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jeftAnim : MonoBehaviour
{
    [SerializeField]
    private GameObject hantei;
    [SerializeField]
    private GameObject yakyuuban;

    Rotate rotate;
    rotateAnim rotateanim;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rotate = hantei.GetComponent<Rotate>();
        rotateanim = yakyuuban.GetComponent<rotateAnim>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (rotate.isEnter == true)
        {
            animator.SetBool("stay", false);
        }
        if (rotateanim.isAnimend == true)
        {
            animator.SetBool("left", true);
        }
        if (rotate.isEnter == false)
        {
            animator.SetBool("left", false);
            animator.SetBool("stay", true);
        }
    }
}

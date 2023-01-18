using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAnim : MonoBehaviour
{
    [SerializeField]
    private GameObject hantei;

    public bool isAnimend = false;

    Rotate rotate;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rotate = hantei.GetComponent<Rotate>();
        this.animator = GetComponent<Animator>();
    }


    void Update()
    {
        if(rotate.isEnter == true)
        {
            animator.SetBool("rotate", true);
            StartCoroutine("Timer");
        }
        else if(rotate.isEnter == false)
        {
            animator.SetBool("rotate", false);
            isAnimend = false;
        }
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2.3f);
        isAnimend = true;
    }
}

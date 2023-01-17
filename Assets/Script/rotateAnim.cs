using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAnim : MonoBehaviour
{
    [SerializeField]
    private GameObject rotate;
    [SerializeField]
    private GameObject delete;

    public bool isAnimend = false;

    rotateBool rotatebool;
    Delete hazure;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rotatebool = rotate.GetComponent<rotateBool>();
        hazure = delete.GetComponent<Delete>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rotatebool.isRotate == true)
        {
            animator.SetBool("boll",true);
            animator.SetBool("bool", false);
            StartCoroutine("Timer");
            isAnimend = false;
        }

        if(hazure.ishazure == true)
        {
            animator.SetBool("bool", true);
            animator.SetBool("boll", false);
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2.3f);
        isAnimend = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightAnim : MonoBehaviour
{
    [SerializeField]
    private GameObject rotate;
    [SerializeField]
    private GameObject delete;
    [SerializeField]
    private GameObject yakyuuban;

    rotateBool rotatebool;
    Delete hazure;
    rotateAnim rotateanim;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rotatebool = rotate.GetComponent<rotateBool>();
        hazure = delete.GetComponent<Delete>();
        rotateanim = yakyuuban.GetComponent<rotateAnim>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rotatebool.isRotate == true)
        {
            animator.SetBool("rightrotate", true);
            animator.SetBool("right", false);
            animator.SetBool("back", false);
        }
        if (rotateanim.isAnimend == true)
        {
            animator.SetBool("right", true);
            animator.SetBool("rightrotate", false);
        }
        if (hazure.ishazure == true)
        {
            animator.SetBool("back", true);
        }
    }
}

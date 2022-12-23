using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingBall : MonoBehaviour
{
    [SerializeField]
    [Header("マイナス方向")]
    private float sliderMin;
    [SerializeField]
    private float sliderMax;
    [Space]
    [SerializeField]
    [Header("プラス方向")]
    private float curveMin;
    [SerializeField]
    private float curveMax;

    private float zSpeed;

    void Start()
    {
        int change = Random.Range(1, 4);

        switch(change)
        {
            case 1:
                zSpeed = 0;
                break;

            case 2:
                zSpeed = Random.Range(sliderMin, sliderMax);
                break;

            case 3:
                zSpeed = Random.Range(curveMin, curveMax);
                break;

            default:
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            Vector3 sliderDirection = new Vector3(0, 0, zSpeed);
            Debug.Log(zSpeed);
            rb.AddForce(sliderDirection * 1);
            this.GetComponent<BoxCollider>().enabled = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCreate : MonoBehaviour
{
    [SerializeField]
    [Tooltip("��������GameObject")]
    private GameObject createPrefab;
    [SerializeField]
    [Tooltip("��������ꏊ")]
    private Transform rangeA;

    bool One;

    void Start()
    {
        One = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (One)
        {
            Instantiate(createPrefab, new Vector3(rangeA.position.x, rangeA.position.y, rangeA.position.z), Quaternion.identity);
            One = false;
        }
    }
}

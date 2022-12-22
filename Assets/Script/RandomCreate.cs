using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCreate : MonoBehaviour
{
    [SerializeField]
    [Tooltip("生成するGameObject")]
    private GameObject createPrefab;
    [SerializeField]
    [Tooltip("生成する場所")]
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

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
    private float time;

    void Start()
    {
        time = 0;
        One = true;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (One == true && time >= 1f)
        {
            Instantiate(createPrefab, new Vector3(rangeA.position.x, rangeA.position.y, rangeA.position.z), Quaternion.identity);
            One = false;
        }
    }
}

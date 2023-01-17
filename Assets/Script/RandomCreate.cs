using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCreate : MonoBehaviour
{
    [SerializeField]
    [Tooltip("ê∂ê¨Ç∑ÇÈGameObject")]
    private GameObject createPrefab;
    [SerializeField]
    [Tooltip("ê∂ê¨Ç∑ÇÈèÍèä")]
    private Transform rangeA;
    [SerializeField]
    private GameObject yakyuuban;

    rotateAnim rotateanim;
    bool One;
    private float time;

    void Start()
    {
        rotateanim = yakyuuban.GetComponent<rotateAnim>();
        time = 0;
        One = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(rotateanim.isAnimend == true)
        {
            time += Time.deltaTime;
        }
        
        if (One == true && time >= 1f)
        {
            Instantiate(createPrefab, new Vector3(rangeA.position.x, rangeA.position.y, rangeA.position.z), Quaternion.identity);
            One = false;
            time = 0f;
        }
    }
}

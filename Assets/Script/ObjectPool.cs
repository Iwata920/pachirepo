using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    //�I�u�W�F�N�g�̃��X�g
    private List<GameObject> _PoolObjList;

    [SerializeField]
    //���ۂɐ�������I�u�W�F�N�g
    private GameObject _PoolObj;

    public void CreatePool(GameObject obj ,int maxCount)
    {
        _PoolObj = obj;
        _PoolObjList = new List<GameObject>();
        for (int i = 0; i < maxCount; i++)
        {
            GameObject newObj = CreateNewObject();
            newObj.SetActive(false);
            _PoolObjList.Add(newObj);
        }
    }

    public GameObject GetObject()
    {
        // �g�p���łȂ����̂�T���ĕԂ�
        foreach (GameObject obj in _PoolObjList)
        {
            if (!obj.activeSelf)
            {
                //�g�p���łȂ��̂Ȃ�I�u�W�F�N�g���A�N�e�B�u�ɂ���
                obj.SetActive(true);
                return obj;
            }
        }
        // �S�Ďg�p����������V��������ĕԂ�
        GameObject newObj = CreateNewObject();
        newObj.SetActive(true);
        _PoolObjList.Add(newObj);

        return newObj;
    }

    private GameObject CreateNewObject()
    {
        GameObject newObj = Instantiate(_PoolObj);
        newObj.name = _PoolObj.name + (_PoolObjList.Count + 1);
        newObj.transform.SetParent(gameObject.transform);

        return newObj;
    }
}

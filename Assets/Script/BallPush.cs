using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPush : MonoBehaviour
{
    private Rigidbody _rigidbody;

   // private bool _isPush = false;               //�ʂ������ꂽ���ǂ���

    string[] CacheJoystickNames;


    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        //�v�[�������I�u�W�F�N�g���ė��p���邽��
        //������������������
        //_pushTime = 1;
        //�t���O��false��
        //_isPush = false;
        _rigidbody.useGravity = false;
        //rigidbody�̑��x���[����
        _rigidbody.velocity = Vector3.zero;
        //��]��������
        transform.rotation = Quaternion.Euler(Vector3.zero);
    }
}

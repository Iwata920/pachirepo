using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bound : MonoBehaviour
{
	/// <summary>
	/// ���˕Ԃ������̕ϐ�
	/// </summary>
	[SerializeField]
	private float bounce = 10f;

	/// <summary>
	/// �Փ˂�����
	/// </summary>
	private void OnCollisionEnter(Collision collision)
	{
		// �������������Rigidbody��x�������ɗ͂�������B
		// �����x���̃}�C�i�X�����ɗ͂������Ē��˕Ԃ��B
		collision.rigidbody.AddForce(-bounce, 0f, 0f, ForceMode.Impulse);
	}
}

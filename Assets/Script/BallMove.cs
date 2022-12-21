using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
     private float _xMove;
     private float _zMove;

    private float _xSpeed;
    private float _zSpeed;

    Rigidbody rigidbody;

    Vector3 pos;
    [SerializeField] GameObject plane;
    float _yPos;

    private bool _isHit;
    [SerializeField]
    float speed = 2;
    

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        //_yPos = plane.transform.position.y;
        //this.transform.position = new Vector3(transform.position.x, _yPos + this.transform.localScale.y , transform.position.z);
    }


    private void Update()
    {
        //if(_isHit)
        //{
        //    _xSpeed = _xMove * Time.deltaTime * speed;
        //    _zSpeed = _zMove * Time.deltaTime * speed;
        //    Debug.Log("�c�̃X�s�[�h" + _xSpeed);
        //    Debug.Log("���̃X�s�[�h" + _zSpeed);
        //    //this.transform.position += new Vector3(_xMove, 0, _zMove) * Time.deltaTime * speed;
        //    rigidbody.AddForce(_xSpeed, 0f, _zSpeed) ;
        //    _isHit = false;
        //}
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "bat")
        {
            //rigidbody.isKinematic = true;
     
            GameObject �o�b�g = collision.gameObject;

            float �o�b�g�̊p�x = �o�b�g.transform.eulerAngles.y;

            float ���ˊp = Mathf.Abs(�o�b�g�̊p�x * 2);
            float ���ˊp = ���ˊp * (�o�b�g�̊p�x < 0 ? -1 : 1);

            float ���ˊp�Q���W�A�� = ���ˊp * Mathf.Deg2Rad;

            float x = Mathf.Cos(���ˊp�Q���W�A��);
            float y = Mathf.Sin(���ˊp�Q���W�A��);

            _xMove = x;
            _zMove = -y;
            _isHit = true;

            _xSpeed = _xMove * speed;
            _zSpeed = _zMove * speed;
            Debug.Log("�c�̃X�s�[�h" + _xSpeed);
            Debug.Log("���̃X�s�[�h" + _zSpeed);
            //this.transform.position += new Vector3(_xMove, 0, _zMove) * Time.deltaTime * speed;
            rigidbody.AddForce(_xSpeed, 0f, _zSpeed);
        }
    }
}

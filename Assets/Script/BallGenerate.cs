using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;

public class BallGenerate : MonoBehaviour
{
    private ObjectPool _ObjectPool;
    private Rigidbody _rigidbody;
    //private PachiController pachiController;
    private PachiJoycon pachiJoycon;
    private SEManager seManager;

    
    [SerializeField] private Text _BallCountText;    //�ʂ̐��p�e�L�X�g

    [SerializeField] private int _BallMaxCount;      //��������ʂ̍ő吔
    [SerializeField] private GameObject _Ball;       //���������
    [SerializeField] private int _coolTime;          //���̋ʂ�ł��o�����߂̎���
    [SerializeField] private float _power;           //�ʂ�ł��o����
    private bool _stop = false;
     
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        //pachiController = GameObject.FindGameObjectWithTag("pachi").GetComponent<PachiController>();
        pachiJoycon = GameObject.FindGameObjectWithTag("pachi").GetComponent<PachiJoycon>();
        seManager = GameObject.FindGameObjectWithTag("SE").GetComponent<SEManager>();

    }

    private void Start()
    {
        _ObjectPool = GetComponent<ObjectPool>();
        //�v�[���̐���
        _ObjectPool.CreatePool(_Ball, _BallMaxCount);
        //�ʂ̐����e�L�X�g�ɕ\��
        _BallCountText.text = _BallMaxCount.ToString();
        _ = TimeCount();
    }

    private void Update()
    {
        _BallCountText.text = _BallMaxCount.ToString();
    }
    private async Task TimeCount()
    {
        while (!_stop)
        {
            //���݂̋ʂ̐��Ƀe�L�X�g���X�V
            if (_BallMaxCount > 0 && pachiJoycon.GetSetPower > 0.1)
            {
                await Task.Delay(200);
                //�ʂ𐶐���
                CreateBall();
                //�ʂ̐������炷
                _BallMaxCount--;
                //���̋ʂ�ł��o���܂łɈ�莞�ԑ҂�
                await Task.Delay(_coolTime);
            }
            else
            {
                await Task.Delay(1);
            }
        }
    }

    private void IsStop()
    {
        _stop = true;
    }

    /// <summary>
    /// �ʂ̐�������
    /// </summary>
    public void CreateBall()
    {
        
        float pushPower = pachiJoycon.GetSetPower;
        float ramdomPower = Random.Range(0.98f, 1.02f);
        //�{�[�����v�[������擾
        GameObject ball = _ObjectPool.GetObject();
        //�ʂ̈ʒu�Ɖ�]���Z�b�g
        ball.transform.SetPositionAndRotation(transform.position, transform.rotation);
        //�ʂɏd�͂Ə�����^����
        ball.GetComponent<Rigidbody>().useGravity = true;
        ball.GetComponent<Rigidbody>().AddForce(pushPower * _power * ramdomPower * Vector3.up, ForceMode.Impulse);
        //Debug.Log("�ł��o����" + pushPower * _power * ramdomPower);
        //�ʂ̑ł��o�����𗬂�
        seManager.SEplay(1);
    }
    
    public int GetSetBallCount
    {
        get { return _BallMaxCount ; }
        set { _BallMaxCount = value; }
    }
}

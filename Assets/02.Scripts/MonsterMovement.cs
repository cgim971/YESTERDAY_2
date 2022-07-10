using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    public Rigidbody2D _rigid;
    // ���� �ӵ�
    public float _speed;
    // �÷��̾� ��
    public Transform _target;
    // ������ �̵��ӵ�
    public Vector3 _velocity;
    // �÷��̾� üũ�� ���� ������
    public float _radius;

    protected void Start()
    {
        if (_rigid == null)
            _rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        CheckPlayer();

        _rigid.velocity = _velocity;
    }

    void CheckPlayer()
    {
        RaycastHit2D hit = Physics2D.CircleCast(transform.position, _radius, Vector2.right, _radius, LayerMask.GetMask("player"));

        // �÷��̾ ��Ÿ��� ������
        if (hit.transform != null)
        {
            _target = hit.transform;

            Vector2 origin = _target.position - transform.position;
            origin.Normalize();

            _velocity = origin * _speed;
        }
        // �÷��̾ ��Ÿ��� ������ ����
        else
        {
            _target = null;

            _velocity = Vector2.zero;
        }
    }
}




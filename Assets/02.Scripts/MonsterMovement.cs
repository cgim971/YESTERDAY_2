using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    public Rigidbody2D _rigid;
    // 몬스터 속도
    public float _speed;
    // 플레이어 값
    public Transform _target;
    // 몬스터의 이동속도
    public Vector3 _velocity;
    // 플레이어 체크를 위한 반지름
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

        // 플레이어가 사거리에 들어오면
        if (hit.transform != null)
        {
            _target = hit.transform;

            Vector2 origin = _target.position - transform.position;
            origin.Normalize();

            _velocity = origin * _speed;
        }
        // 플레이어가 사거리에 들어오지 않음
        else
        {
            _target = null;

            _velocity = Vector2.zero;
        }
    }
}




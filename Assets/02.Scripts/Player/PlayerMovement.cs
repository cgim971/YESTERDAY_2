using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigid;
    private SpriteRenderer _spriteRenderer;
    private Animator _animator;

    [SerializeField] private float _speed;
    [SerializeField] private Vector2 _velocity;
    [SerializeField] Vector2 _amount;

    private void Start()
    {
        if (_rigid == null)
            _rigid = GetComponent<Rigidbody2D>();
        if (_spriteRenderer == null)
            _spriteRenderer = GetComponent<SpriteRenderer>();
        if (_animator == null)
            _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Move();
    }

    private void FixedUpdate()
    {
        ChangeAnimation();
    }

    private void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        _amount = new Vector2(h, v);
        _velocity = _amount.normalized;

        _rigid.velocity = _velocity * _speed;
    }

    private void ChangeAnimation()
    {
        Vector2 plyaerPos = transform.position;
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _spriteRenderer.flipX = mousePos.x == plyaerPos.x ? _spriteRenderer.flipX : mousePos.x > plyaerPos.x;

        if (_amount.x == 0 && _amount.y == 0)
            _animator.SetBool("isRun", false);
        else
            _animator.SetBool("isRun", true);
    }
}

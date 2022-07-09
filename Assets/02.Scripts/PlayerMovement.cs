using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D _rigid;
    public float _speed;

    private void Start()
    {
        if (_rigid == null)
            _rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }
    
    private void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector2 amount = new Vector2(h, v);
        amount.Normalize();

        _rigid.velocity = amount * _speed;
    }
}

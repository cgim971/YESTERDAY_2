using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    public Rigidbody2D _rigid;
    public float _speed;
    public bool _isTarget;
    public Transform _target;

    protected void Start()
    {
        if (_rigid == null)
            _rigid = GetComponent<Rigidbody2D>();

        StartCoroutine(Move());
    }



    IEnumerator Move()
    {
        while (true)
        {
            yield return new WaitUntil(() => _isTarget);

            int h = (int)Random.Range(-1f, 2f);
            int v = (int)Random.Range(-1f, 2f);

            Vector2 amount = new Vector2(h, v);
            amount.Normalize();

            _rigid.velocity = amount *_speed;
        }
    }


}

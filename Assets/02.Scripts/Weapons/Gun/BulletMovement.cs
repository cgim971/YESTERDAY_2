using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float _speed;
    private void Update()
    {
        transform.Translate(Vector2.right * _speed * Time.deltaTime);
    }
}

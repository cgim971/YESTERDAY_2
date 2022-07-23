using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponUse : MonoBehaviour
{
    [SerializeField] FistData _fistData;
    [SerializeField] GunData _gunData;


    public GameObject bullet;
    public Transform shotPos;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) TestGun();
    }

    void TestGun()
    {
        GameObject newBullet = Instantiate(bullet, null);
        newBullet.transform.position = shotPos.position;
        newBullet.transform.rotation = transform.rotation;
        newBullet.GetComponent<BulletMovement>().SPEED = _gunData._bulletSpeed;
    }
}

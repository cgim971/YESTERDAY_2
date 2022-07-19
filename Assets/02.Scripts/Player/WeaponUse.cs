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

    private void Start()
    {

    }

    private IEnumerator UseWeapon()
    {
        while (true)
        {

            //yield return WaitUntil();



        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) TestGun();
    }

    void TestGun()
    {
        GameObject newBullet = Instantiate(bullet, null);
        newBullet.transform.position = shotPos.position;
        newBullet.transform.rotation = transform.rotation;
    }


    //private void UseWeapon()
    //{
    //    EquipmentWeaponType equipmentWeaponType = SaveManager.instance.PLAYERDATA.EQUIPMENTWEAPONTYPE;
    //    switch (equipmentWeaponType)
    //    {
    //        case EquipmentWeaponType.NONE:
    //            SaveManager.instance.PLAYERDATA.EQUIPMENTWEAPONTYPE = EquipmentWeaponType.FIST;
    //            UseWeapon();
    //            return;
    //        case EquipmentWeaponType.FIST:
    //            StartCoroutine(UseFist());
    //            break;
    //        case EquipmentWeaponType.GUN:
    //            UseGun();
    //            break;
    //    }
    //}

    private IEnumerator UseFist()
    {
        if (_fistData == null) yield break;

        // 주먹 애니메이션

    }
    private void SelectGun(GunData gunData)
    {
        _gunData = gunData;
    }

    private void UseGun()
    {
        if (_gunData == null) return;


    }

}

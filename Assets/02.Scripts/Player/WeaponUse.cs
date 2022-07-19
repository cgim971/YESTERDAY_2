using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponUse : MonoBehaviour
{
    [SerializeField] FistData _fistData;
    [SerializeField] GunData _gunData;



    private void UseWeapon()
    {
        EquipmentWeaponType equipmentWeaponType = SaveManager.instance.PLAYERDATA.EQUIPMENTWEAPONTYPE;
        switch (equipmentWeaponType)
        {
            case EquipmentWeaponType.NONE:
                SaveManager.instance.PLAYERDATA.EQUIPMENTWEAPONTYPE = EquipmentWeaponType.FIST;
                UseWeapon();
                return;
            case EquipmentWeaponType.FIST:
                UseFist();
                break;
            case EquipmentWeaponType.GUN:
                UseGun();
                break;
        }
    }
    private void UseFist()
    {
        if (_fistData == null) return;


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

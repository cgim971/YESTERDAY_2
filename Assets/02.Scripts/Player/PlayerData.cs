using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{

    [SerializeField] private string _playerName;
    public string PLAYERNAME
    {
        get => _playerName;
        set
        {
            _playerName = value;
            SaveManager.instance.SavePlayerName(_playerName);
        }
    }


    [SerializeField] private EquipmentWeaponType _equipmentWeaponType;
    public EquipmentWeaponType EQUIPMENTWEAPONTYPE
    {
        get => _equipmentWeaponType;
        set
        {
            _equipmentWeaponType = value;
            SaveManager.instance.SaveEquipmentWeaponType(_equipmentWeaponType);
        }
    }

    public PlayerData(string playerName, EquipmentWeaponType equipmentWeaponType)
    {
        PLAYERNAME = playerName;
        EQUIPMENTWEAPONTYPE = equipmentWeaponType;
    }
}

public enum EquipmentWeaponType
{
    NONE = 0,
    FIST = 1,
    GUN = 2,
}
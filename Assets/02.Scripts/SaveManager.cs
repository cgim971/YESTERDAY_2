using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{

    public static SaveManager instance;

    [SerializeField] PlayerData _playerData;

    public PlayerData PLAYERDATA { get => _playerData; }

    private void Awake()
    {
        instance = this;

        LoadData();
    }

    void LoadData()
    {
        var playerName = PlayerPrefs.GetString("PLAYERNAME", "");

        var playerEquipmentWeaponJsonStr = PlayerPrefs.GetString("EQUIPMENTWEAPONTYPE", "");
        EquipmentWeaponType playerEquipmentWeapon = JsonUtility.FromJson<EquipmentWeaponType>(playerEquipmentWeaponJsonStr);

        _playerData = new PlayerData(playerName, playerEquipmentWeapon);
    }








    public void SavePlayerName(string playerName)
    {
        PlayerPrefs.SetString("PLAYERNAME", playerName);
    }
    public void SaveEquipmentWeaponType(EquipmentWeaponType equipmentWeaponType)
    {
        string jsonStr = JsonUtility.ToJson(equipmentWeaponType);
        PlayerPrefs.SetString("EQUIPMENTWEAPONTYPE", jsonStr);
    }

}

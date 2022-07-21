using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GunData", menuName = "ScriptableObject/Weapons/Gun")]
public class GunData : ScriptableObject
{
    public WeaponInfo _weaponInfo;

    public int _bulletMaxCount;
    public GunBullet _gunBullet;
    public List<GunType> _gunType;
    public int _gunTypeIndex;

    public float _bulletSpeed;
}

public enum GunBullet
{
    NONE = 0,
    FIVE = 1,
    SEVEN = 2,
    NINE = 3,
    TWELVE = 4,
    THREEHUNDRED = 5,
}
public enum GunType
{
    NONE = 0,
    SINGLESHOT = 1,
    MULTIPLESHOT = 2,
    SHOTGUN_1 = 3,
    SHOTGUN_2 = 4,
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Assets/ScriptableObject/Weapons")]

public class WeaponType : ScriptableObject
{
    // 무기 이름
    public string _name;
    // 무기의 데미지
    public float _damage;
    // 총알 갯수
    public long _bulletCount;
    // 사용하는 총알
    public BulletType _bulletType;
    public enum BulletType
    {
        NONE = 0,
        BULLET_5 = 1,
        BULLET_7 = 2,
        BULLET_9 = 3,
        BULLET_12 = 4,
        BULLET_300 = 5,
    }

    public enum ShotType
    {

    }
}
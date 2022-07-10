using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Assets/ScriptableObject/Weapons")]

public class WeaponType : ScriptableObject
{
    // ���� �̸�
    public string _name;
    // ������ ������
    public float _damage;
    // �Ѿ� ����
    public long _bulletCount;
    // ����ϴ� �Ѿ�
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
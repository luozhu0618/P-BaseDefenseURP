﻿using UnityEngine;
using System.Collections;

// 产生游戏角色工厂界面
public abstract class ICharacterFactory
{
    // 建立Soldier
    public abstract ISoldier CreateSoldier( ENUM_Soldier emSoldier, ENUM_Weapon emWeapon, int Lv,Vector3 SpawnPosition);
   
    // 建立Enemy
    public abstract IEnemy CreateEnemy( ENUM_Enemy emEnemy, ENUM_Weapon emWeapon, Vector3 SpawnPosition, Vector3 AttackPosition);
   
}
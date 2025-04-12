using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UnitStats
{
    public int level = 1;
    [SerializeField]
    private int moveSpeed = 300;
    public float MoveSpeed{
        get=> moveSpeed / 100;
    }
    public int hp;
    public int resource;
    public int ad; // Attack Damage
    public int ap; // Ability Power
    public int attackSpeed;
    public int armor; // 방어력 
    public int mr; // Magic Resist (마법 저항력)
    public int hr; // Health Regeneration (체력 재생)
    public int ah; // Ability Haste (스킬 가속)
}

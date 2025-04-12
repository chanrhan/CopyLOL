using UnityEngine;

public abstract class Unit : Entity {
    [Header("Unit")]
    [SerializeField]
    protected UnitStats stats;
    public UnitStats Stats{
        get=>stats;
    }

    public bool isMoving;
    public bool isAttacking;
    
    public virtual int OnDamaged(int amount){
        hp -= amount;
        return hp;
    }

    protected virtual void LevelUp(){

    }

}
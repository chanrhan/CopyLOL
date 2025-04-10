using UnityEngine;

public abstract class Unit : Entity {
    public virtual int OnDamaged(int amount){
        hp -= amount;
        return hp;
    }

    
}
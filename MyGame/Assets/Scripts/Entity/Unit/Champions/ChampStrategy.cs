using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChampStrategy 
{
    [SerializeField]
    protected Dictionary<EAbilityKeycode, AbilityInfo> abilities = new Dictionary<EAbilityKeycode, AbilityInfo>(){
        
    };

    public int GetAbilityCooldown(EAbilityKeycode keycode){
        return abilities[keycode].GetCooldown();
    }

    public int GetAbilityResourceCost(EAbilityKeycode keycode){
        return abilities[keycode].GetResourceCost();
    }

    public void UseAbility(EAbilityKeycode keycode){

    }

    public abstract void Move();
    public abstract void Attack();
    public abstract void UsePassiveAbility();
    public abstract void UseAbilityQ();
    public abstract void UseAbilityW();
    public abstract void UseAbilityE();
    public abstract void UseAbilityR();
    // Cal abstractlback
    public abstract void OnMove();
    public abstract void OnAttack();
    public abstract void OnDie();
    public abstract void OnKill();
    public abstract void OnAssist();
}

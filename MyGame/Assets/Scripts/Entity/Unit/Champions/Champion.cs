using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Champion : Nonneutral
{
    [Header("Champion")]
    private List<AbilityInfo> abilityInfos = new List<AbilityInfo>(5);

    public List<AbilityInfo> AbilityInfos{
        get=>abilityInfos;
    }

    protected string champName;

    protected override void Awake()
    {
        base.Awake();
        if(abilityInfos.Count < 5){
            throw new Exception($"{champName} : 스킬을 등록해주세요!");
        }

        abilityInfos[1].OnUseAbiliy = UseAbility1;
        abilityInfos[2].OnUseAbiliy = UseAbility2;
        abilityInfos[3].OnUseAbiliy = UseAbility3;
        abilityInfos[4].OnUseAbiliy = UseAbility4;

        abilityInfos[1].CanUseAbility = CanAbility1;
        abilityInfos[2].CanUseAbility = CanAbility2;
        abilityInfos[3].CanUseAbility = CanAbility3;
        abilityInfos[4].CanUseAbility = CanAbility4;
    }

    protected override void LevelUp(){
        Debug.Log($"({champName}) : Level Up");
    }

    public virtual void Move(){
        Debug.Log($"({champName}) : Move");
    }
    public virtual void Attack(){
        Debug.Log($"({champName}) : Attack");
    }
    
    // Use Ability
    public virtual void UsePassiveAbility(){
         Debug.Log($"({champName}) : Use Passive");
    }
    public virtual void UseAbility1(){
         Debug.Log($"({champName}) : Use Ab 1");
    }
    public virtual void UseAbility2(){
        Debug.Log($"({champName}) : Use Ab 2");
    }
    public virtual void UseAbility3(){
        Debug.Log($"({champName}) : Use Ab 3");
    }
    public virtual void UseAbility4(){
        Debug.Log($"({champName}) : Use Ab 4");
    }


    // Can Use Ability 
    public virtual bool CanAbility1(){
        return true;
    }
    public virtual bool CanAbility2(){
        return true;
    }
    public virtual bool CanAbility3(){
        return true;
    }
    public virtual bool CanAbility4(){
        return true;
    }


    // Cal abstractlback
    public virtual void OnMove(){
        Debug.Log($"({champName}) : On Move");
    }
    public virtual void OnAttack(){
        Debug.Log($"({champName}) : On Attack");
    }
    public virtual void OnDie(){
        Debug.Log($"({champName}) : On Die");
    }
    public virtual void OnKill(){
        Debug.Log($"({champName}) : On Kill");
    }
    public virtual void OnAssist(){
        Debug.Log($"({champName}) : On Assist");
    }
}

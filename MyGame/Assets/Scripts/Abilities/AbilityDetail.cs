using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AbilityDetail 
{
    public int lev = 0;
    public int[] resourceCost;

    public float currCooldown;
    public float[] cooldown;

    public AbilityPreview[] previews = new AbilityPreview[1];

    public Action OnUseAbiliy;
    public Func<bool> CanUseAbility;

    public AbilityDetail(){
        
    }

    public void IncreaseLevel(int amount=1){
        if(lev + amount > 5){
            throw new Exception("Max level!");
        }
        lev += amount;
    }

    public int GetResourceCost(){
        return resourceCost[lev];
    }

     public float GetCooldown(){
        return cooldown[lev];
    }
}

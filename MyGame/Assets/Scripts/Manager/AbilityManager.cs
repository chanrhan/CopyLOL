using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class AbilityManager : MonobehaviourSingleton<AbilityManager>
{

    [SerializeField]
    private float cooldownPerTime = 0.5f;

    private UnitStats stats;

    private Dictionary<KeyCode, int> abilityKeyMap = new Dictionary<KeyCode, int>(){
        {KeyCode.Q, 1},
        {KeyCode.W, 2},
        {KeyCode.E, 3},
        {KeyCode.R, 4},
    };

    private List<AbilityInfo> abilityInfo;

    public void Init(Champion champ){
        abilityInfo = champ.AbilityInfos;
        stats = champ.Stats;
    }

    public bool CanUseAbility(int idx){
        AbilityInfo ab = abilityInfo[idx];

        if(stats.resource < ab.GetResourceCost()){
            return false;
        }

        if(ab.currCooldown > 0){
            return false;
        }

        return ab.CanUseAbility();
    }

    public void UseAbility(KeyCode keyCode){
        int idx = abilityKeyMap[keyCode];
        if(idx <= 0){
            throw new System.Exception("Invalid Keycode");
        }

        if(CanUseAbility(idx)){
            StartCoroutine(CooldownCoroutine(idx));
            abilityInfo[idx].OnUseAbiliy();
        }
    }
    
    public void IncreaseAbilityLevel(int abilityCode, int amount=1){
        abilityInfo[abilityCode].IncreaseLevel(amount);
    }

    private IEnumerator CooldownCoroutine(int idx){
        AbilityInfo ab = abilityInfo[idx];
        ab.currCooldown = ab.GetCooldown();
        while(ab.currCooldown > 0){
            ab.currCooldown -= cooldownPerTime;
            yield return new WaitForSeconds(cooldownPerTime);
        }
    }
    


}
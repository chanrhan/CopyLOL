using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    private Champion champion;
    private Rigidbody champRigid;
    private ChampStrategy strategy;

    private Dictionary<EAbilityKeycode, UnityAction> abilityActions;

    public void SetChampion(ChampnInfo championInfo){
        champion = championInfo.championObject;
        champRigid = champion.GetComponent<Rigidbody>();

        strategy = championInfo.strategy; 

        abilityActions = new Dictionary<EAbilityKeycode, UnityAction>(){
            {EAbilityKeycode.Passive, strategy.UsePassiveAbility},
            {EAbilityKeycode.Q, strategy.UseAbilityQ},
            {EAbilityKeycode.W, strategy.UseAbilityW},
            {EAbilityKeycode.E, strategy.UseAbilityE},
            {EAbilityKeycode.R, strategy.UseAbilityR},
        };
    }

    public void MovePosition(){
        strategy.Move();
    }

    public void Attack(){
        strategy.Attack();
    }

    public void UseAbility(EAbilityKeycode abilityType){
        abilityActions[abilityType].Invoke();
    }

}

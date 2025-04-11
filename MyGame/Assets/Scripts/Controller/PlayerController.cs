using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    private Champion champion;
    private Rigidbody champRigid;

    private Dictionary<EAbilityKeycode, UnityAction> abilityActions;

    public void SetChampion(ChampInfo championInfo){
        champion = championInfo.championObject;
        champRigid = champion.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Q)){
            AbilityManager.Instance.UseAbility(KeyCode.Q);
        }
        if(Input.GetKey(KeyCode.W)){
            AbilityManager.Instance.UseAbility(KeyCode.W);
        }
        if(Input.GetKey(KeyCode.E)){
            AbilityManager.Instance.UseAbility(KeyCode.E);
        }
        if(Input.GetKey(KeyCode.R)){
            AbilityManager.Instance.UseAbility(KeyCode.R);
        }
    }

    public void MovePosition(){
        
    }

    public void Attack(){

    }


}

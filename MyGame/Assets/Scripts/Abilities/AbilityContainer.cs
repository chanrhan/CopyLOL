using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[Serializable]
public class AbilityContainer
{
    public int maxLev = 4;
    public AbilityDetail[] abilityDetails;

    public AbilityContainer(){
        abilityDetails = new AbilityDetail[5];
        for(int i=0;i<abilityDetails.Length;++i){
            abilityDetails[i] = new AbilityDetail();
        }
    }

    public AbilityDetail this[int index]{
        get{
            return abilityDetails[index];
        }
    }
}

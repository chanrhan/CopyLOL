using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityInfo : ScriptableObject
{
    public int lev;
    public int[] resourceCost;
    public int[] cooldown;

    public int GetResourceCost(){
        return resourceCost[lev];
    }

     public int GetCooldown(){
        return cooldown[lev];
    }
}

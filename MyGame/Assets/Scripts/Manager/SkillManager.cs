using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour 
{
    [SerializeField]
    private static Dictionary<SkillCode, SkillData> skillDic;
    
    public static SkillData find(SkillCode skillCode){
        return skillDic[skillCode];
    }
}
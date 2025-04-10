using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChampnInfo : ScriptableObject
{
    public string champName;
    public int champCode;
    public int skinCount;
    public Champion championObject;
    public ChampStrategy strategy;
    
}

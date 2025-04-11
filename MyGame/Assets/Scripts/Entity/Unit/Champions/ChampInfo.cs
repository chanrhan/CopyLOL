using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Champion Info", menuName = "ScriptableObject/Champion Info", order = int.MaxValue)]
public class ChampInfo : ScriptableObject
{
    public Sprite champImg;
    public string champName;
    public int champCode;
    public int skinCount;
    public Champion championObject;   
}

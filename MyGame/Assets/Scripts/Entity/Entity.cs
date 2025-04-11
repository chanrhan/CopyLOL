using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    [Header("Entity")]
    [SerializeField]
    protected UIType[] headUIBar;
    protected int hp;
    protected int level;
    public int Hp{
        get=>hp;
    }
    

    protected virtual void Awake() {
        
    }
}

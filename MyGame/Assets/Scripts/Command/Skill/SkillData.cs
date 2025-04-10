using System.Windows.Input;
using UnityEngine;

public abstract class SkillData
{
    [SerializeField]
    protected Object[] prefabs;
    [SerializeField]
    protected SkillPreviewType previewType;
    [SerializeField]
    protected float rangeWidth;
    [SerializeField]
    protected float rangeHeight;

    public int CoolDownTime{get;set;}


    public bool execute(SkillController hero)
    {
        if(check(hero)){
            run(hero);
            return true;
        }
        return false;
    }

    public abstract void run(SkillController unit);

    public abstract bool check(SkillController unit);
}
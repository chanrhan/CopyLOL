using UnityEngine;

public class SkillController{
    public int mana;

    [SerializeField]
    private SkillCode[] skillCodes;

    protected SkillCommand[] commands = null;

    public void Init() {
        commands = new SkillCommand[skillCodes.Length];
        for(int i=0;i<skillCodes.Length;++i){
            commands[i] = new SkillCommand(skillCodes[i]);
        }
    }

    public bool UseSkill(int index){
        return commands[index].execute(this);
    }
}
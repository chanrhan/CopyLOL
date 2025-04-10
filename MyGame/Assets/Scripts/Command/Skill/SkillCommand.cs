public class SkillCommand{
    public SkillCode skillCode;
    public int currCoolDown = 0;

    public SkillCommand(SkillCode skillCode){
        this.skillCode = skillCode;
    }
    public bool execute(SkillController hero){
        SkillData sc = SkillManager.find(skillCode);
        if(currCoolDown == 0){
            if(sc.execute(hero)){
                setTimer(sc.CoolDownTime);
                return true;
            }
        }
        return false;
    }

    public void setTimer(int amount){
        currCoolDown = amount;
    }

    public void addTimer(int amount){
        currCoolDown += amount;
    }
}
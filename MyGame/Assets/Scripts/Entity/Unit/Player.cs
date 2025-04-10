using UnityEngine;

public class Player : Unit {
    [SerializeField]
    private SkillController skillContainer;
    
    private Inventory inventory;

    public void useSkill(int keyCode){
        skillContainer.UseSkill(keyCode);
    }
}
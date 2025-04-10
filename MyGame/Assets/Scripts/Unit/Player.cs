using UnityEngine;

public class Player : Unit {
    [SerializeField]
    private PlayableUnit hero;
    
    private Inventory inventory;

    public void useSkill(int keyCode){
        hero.UseSkill(keyCode);
    }
}
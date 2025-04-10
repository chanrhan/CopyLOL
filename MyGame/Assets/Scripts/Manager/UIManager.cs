using UnityEngine;

public class UIManager : MonoBehaviour {
    private UIManager Instance = null;
    public UIManager(){
        if(Instance == null){
            Instance = new UIManager();
        }
    }

    

}
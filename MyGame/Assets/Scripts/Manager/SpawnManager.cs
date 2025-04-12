using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnManager : MonobehaviourSingleton<SpawnManager>
{
    [HideInInspector]
    public ChampInfo champInfo;

    protected override void Awake()
    {
        base.Awake();
        SceneManager.sceneLoaded += LoadInGameScene;
    }

    private void LoadInGameScene(Scene scene, LoadSceneMode mode){
        if(scene.name != PropertyUtil.inGameSceneName){
            return;
        }

        GameObject go = Instantiate(champInfo.championObject.gameObject);
        PlayerController.Instance.SetChampion(go);
    }
}

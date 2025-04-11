using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LobbyManager : MonobehaviourSingleton<LobbyManager>
{

    [SerializeField]
    private Button btnChoose;

    [SerializeField]
    private Button btnStart;
    [SerializeField]
    private ChampionList championList;
    [SerializeField]
    private Image selectedChampImg;

    protected override void Awake()
    {
        base.Awake();
        championList = GetComponentInChildren<ChampionList>();
    }

    void Start()
    {
        btnStart.onClick.AddListener(StartGame);
        btnChoose.onClick.AddListener(ChooseComplete);
    }

    private void ChooseComplete(){
        ChampInfo champInfo = championList.SelectChamp;
        selectedChampImg.sprite = champInfo.champImg;
        selectedChampImg.gameObject.SetActive(true);
        championList.gameObject.SetActive(false);
        btnChoose.gameObject.SetActive(false);
        btnStart.gameObject.SetActive(true);

        SpawnManager.Instance.champInfo = champInfo;
    }

    private void StartGame(){
        if(!SpawnManager.Instance.champInfo){
            Debug.Log("먼저 챔피언을 선택해 주세요!");
            return;
        }
        SceneManager.LoadScene(PropertyUtil.inGameSceneName);
    }

    

}

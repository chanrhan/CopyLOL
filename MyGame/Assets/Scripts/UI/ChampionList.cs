using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChampionList : MonoBehaviour
{
    [SerializeField]
    private GameObject champBox;

    private ChampInfo[] champions;

    private ChampBox[] champBoxes;

    private int selected = 0;

    public ChampInfo SelectChamp{
        get=>champions[selected];
    }

    void Awake()
    {
        LoadAllChampion();
    }

    private void LoadAllChampion(){
        champions = Resources.LoadAll<ChampInfo>("ChampList");
        champBoxes = new ChampBox[champions.Length];
    }

    void Start()
    {
        for(int i=0;i<champions.Length;++i){
            GameObject go = Instantiate(champBox, gameObject.transform);
            champBoxes[i] = go.GetComponent<ChampBox>();
            champBoxes[i].Set(champions[i].champImg, champions[i].champName);
            int a = i;
            champBoxes[i].onClick.AddListener(()=>{
                Select(a);
            });
        }
    }

    private void Select(int idx){
        // Debug.Log($"Select: {idx}");
        selected = idx;
        foreach(ChampBox box in champBoxes){
            box.UnSelect();
        }

        champBoxes[idx].SelectChamp();
    }

}

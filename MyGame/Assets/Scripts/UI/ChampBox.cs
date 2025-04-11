using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChampBox : Button
{
    public Image champImg;
    public TextMeshProUGUI champName;
    [SerializeField]
    private GameObject selectImage;

    public void Set(Sprite sprite, string name){
        champImg.sprite = sprite;
        champName.text = name;
    }

    public void SelectChamp(){
        selectImage.SetActive(true);
    }
    public void UnSelect(){
        selectImage.SetActive(false);
    }

}

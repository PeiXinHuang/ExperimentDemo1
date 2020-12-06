﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 场景控制器：控制场景中物体的显示，以及实验进度
 */

public class SenceController : MonoBehaviour
{


    public GameObject purposeMenu;  //目的与要求界面
    public GameObject exStepsMenu; //实验步骤面板
    public GameObject StepdDeatailsPanel1; //步骤一详情面板
    public GameObject StepdDeatailsPanel2; //步骤二详情面板
    public GameObject StepdDeatailsPanel3; //步骤三详情面板
    public GameObject StepdDeatailsPanel4; //步骤四详情面板


    private GameObject pineRoot; //树根模型
    private GameObject pineFruit; //松果模型

    // Start is called before the first frame update
    void Start()
    {
        string pineRootPath = "pineRootPrefab";
        pineRoot = (GameObject)Instantiate(Resources.Load(pineRootPath)); //加载树根模型
        string pineFruitPath = "pineFruitPrefab";
        pineFruit = (GameObject)Instantiate(Resources.Load(pineFruitPath)); //加载松果模型
        ReStartExOne();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 开始实验，开始实验时默认进入步骤一
    public void StartExOne()
    {
        ShowExOneStep1();
    }

    // 重新开始实验，回到目的与要求界面
    public void ReStartExOne()
    {
        ResetSence();
        purposeMenu.SetActive(true);
    }

    //重置掉场景中的所有物体
    public void ResetSence()
    {
        // 隐藏菜单面板
        purposeMenu.SetActive(false);
        exStepsMenu.SetActive(false);
        

        //隐藏所有详情面板
        StepdDeatailsPanel1.SetActive(false);
        StepdDeatailsPanel2.SetActive(false);
        StepdDeatailsPanel3.SetActive(false);
        StepdDeatailsPanel4.SetActive(false);

        //隐藏模型
        pineRoot.SetActive(false);
        pineFruit.SetActive(false);
    }


    //显示步骤一模型
    public void ShowExOneStep1()
    {
        ResetSence();
        exStepsMenu.SetActive(true);
        pineRoot.SetActive(true);
    }

    //显示步骤二模型
    public void ShowExOneStep2()
    {
        ResetSence();
        exStepsMenu.SetActive(true);
        pineFruit.SetActive(true);
    }

    //显示步骤三模型
    public void ShowExOneStep3()
    {
        ResetSence();
        exStepsMenu.SetActive(true);
    }

    //显示步骤四模型
    public void ShowExOneStep4()
    {
        ResetSence();
        exStepsMenu.SetActive(true);
      
    }

    //显示详情一面板
    public void ShowStepDetailsPanel1()
    {
        StepdDeatailsPanel1.SetActive(true);
    }

    //显示详情二面板
    public void ShowStepDetailsPanel2()
    {
        StepdDeatailsPanel2.SetActive(true);
    }

    //显示详情三面板
    public void ShowStepDetailsPanel3()
    {
        StepdDeatailsPanel3.SetActive(true);
    }

    //显示详情四面板
    public void ShowStepDetailsPanel4()
    {
        StepdDeatailsPanel4.SetActive(true);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * 实验一按钮点击响应脚本，需要传入按钮，按钮点击后，根据按钮调用场景控制器里面的函数 
 */
public class ExOneBtnClick : MonoBehaviour
{

    public enum BtnNum
    {
        StepOne,
        StepTwo,
        StepThree,
        StepFour,
        ReStart,
        Start
    };

    public BtnNum btnNum;//获取按钮步骤号

    // Start is called before the first frame update
    void Start()
    {
        //绑定按钮事件
        this.GetComponent<Button>().onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //根据按钮编号，执行按钮点击事件
    public void OnButtonClick()
    {
        switch (btnNum)
        {
            case BtnNum.StepOne:
                GameObject.Find("SenceController").GetComponent<SenceController>().ShowExOneStep1();
                break;
            case BtnNum.StepTwo:
                GameObject.Find("SenceController").GetComponent<SenceController>().ShowExOneStep2();
                break;
            case BtnNum.StepThree:
                GameObject.Find("SenceController").GetComponent<SenceController>().ShowExOneStep3();
                break;
            case BtnNum.StepFour:
                GameObject.Find("SenceController").GetComponent<SenceController>().ShowExOneStep4();
                break;
            case BtnNum.Start:
                GameObject.Find("SenceController").GetComponent<SenceController>().StartExOne();                break;
            case BtnNum.ReStart:
                GameObject.Find("SenceController").GetComponent<SenceController>().ReStartExOne();
                break;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 场景控制器：控制场景中物体的显示，以及实验进度
 */

public class SenceController : MonoBehaviour
{


    public GameObject purpose;  //目的与要求界面
    public GameObject exSteps; //实验步骤面板

    private GameObject pineRoot; //树根模型

    // Start is called before the first frame update
    void Start()
    {
        string pineRootPath = "pineRoot";
        pineRoot = (GameObject)Instantiate(Resources.Load(pineRootPath)); //加载树根模型

        ReStartExOne();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 开始实验
    public void StartExOne()
    {
        HidePurpose();
        ShowExSteps();
        ShowExOneStep1();
    }

    // 重新开始实验
    public void ReStartExOne()
    {
        ShowPurpose();
        HideExSteps();
        pineRoot.SetActive(false);
    }

    

    //显示目的与要求界面
    private void ShowPurpose()
    {
        purpose.SetActive(true);
    }

    //隐藏目的与要求界面
    private void HidePurpose()
    {
        purpose.SetActive(false);
    }

    //显示实验步骤面板
    private void ShowExSteps()
    {
        exSteps.SetActive(true);
    }

    //隐藏实验步骤面板
    public void HideExSteps()
    {
        exSteps.SetActive(false);
    }

    //显示步骤一
    public void ShowExOneStep1()
    {

        pineRoot.SetActive(true);


    }

    //显示步骤二
    public void ShowExOneStep2()
    {
        
        pineRoot.SetActive(false);
        
    }

    //显示步骤三
    public void ShowExOneStep3()
    {
        pineRoot.SetActive(false);
    }

    //显示步骤四
    public void ShowExOneStep4()
    {
        pineRoot.SetActive(false);
    }

}

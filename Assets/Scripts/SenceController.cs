using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 场景一控制器：控制场景中物体的显示，以及实验进度
 */

public class SenceController : MonoBehaviour
{


    public GameObject purposeMenu;  //目的与要求界面
    public GameObject exStepsMenu; //实验步骤面板
    public GameObject StepDeatailsPanel1; //步骤一详情面板
    public GameObject StepDeatailsPanel2; //步骤二详情面板
    public GameObject StepDeatailsPanel3; //步骤三详情面板
    public GameObject StepDeatailsPanel4; //步骤四详情面板


    private GameObject pineRoot; //树根模型
    private GameObject pineFruit; //松果模型
    private GameObject microscope; //显微镜模型
    private GameObject pineFree; //松叶模型

    // Start is called before the first frame update
    void Start()
    {

        pineRoot = (GameObject)Instantiate(Resources.Load("pineRootPrefab")); //加载树根模型
        pineFruit = (GameObject)Instantiate(Resources.Load("pineFruitPrefab")); //加载松果模型
        microscope = (GameObject)Instantiate(Resources.Load("microscopePrefab")); //加载显微镜模型
        pineFree = (GameObject)Instantiate(Resources.Load("pineLeafPrefab")); //加载松叶模型

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
        StepDeatailsPanel1.SetActive(false);
        StepDeatailsPanel2.SetActive(false);
        StepDeatailsPanel3.SetActive(false);
        StepDeatailsPanel4.SetActive(false);

        //隐藏模型
        pineRoot.SetActive(false);
        pineFruit.SetActive(false);
        pineFree.SetActive(false);
        microscope.SetActive(false);
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
        pineFree.SetActive(true);
        exStepsMenu.SetActive(true);
        
    }

    //显示步骤三模型
    public void ShowExOneStep3()
    {
        ResetSence();
        microscope.SetActive(true);
        exStepsMenu.SetActive(true);
       
    }

    //显示步骤四模型
    public void ShowExOneStep4()
    {
        ResetSence();
        exStepsMenu.SetActive(true);
        pineFruit.SetActive(true);
    }

    //设置详情一面板，如果已经显示面板，那么就隐藏，否之即反
    public void SetStepDetailsPanel1()
    {
        if (StepDeatailsPanel1.activeInHierarchy)
        {
            
            StepDeatailsPanel1.SetActive(false);
        }
        else
        {
            StepDeatailsPanel1.SetActive(true);
           
            
        }
    }

    //设置详情二面板，如果已经显示面板，那么就隐藏，否之即反
    public void SetStepDetailsPanel2()
    {
        if (StepDeatailsPanel2.activeInHierarchy)
        {
            StepDeatailsPanel2.SetActive(false);
        }
        else
        {
            StepDeatailsPanel2.SetActive(true);
        }
    }

    //设置详情三面板，如果已经显示面板，那么就隐藏，否之即反
    public void SetStepDetailsPanel3()
    {
        if (StepDeatailsPanel3.activeInHierarchy)
        {
            StepDeatailsPanel3.SetActive(false);
        }
        else
        {
            StepDeatailsPanel3.SetActive(true);
        }
    }

    //设置详情四面板，如果已经显示面板，那么就隐藏，否之即反
    public void SetStepDetailsPanel4()
    {
        if (StepDeatailsPanel4.activeInHierarchy)
        {
            StepDeatailsPanel4.SetActive(false);
        }
        else
        {
            StepDeatailsPanel4.SetActive(true);
        }
    }


}

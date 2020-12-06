using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*
*  模型点击脚本，模型点击时,根据当前步骤，点击显示步骤详情面板,再次点击，隐藏详情面板
*/
public class ModelClick : MonoBehaviour
{
    //详情面板列表
    public enum StepDetailNum
    {
        Step1,
        Step2,
        Step3,
        Step4
    };

    public StepDetailNum currentStep; //当前详情面板

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //点击模型显示详情面板
    private void OnMouseDown()
    {
       
        switch (currentStep)
        {
            case StepDetailNum.Step1:
                GameObject.Find("SenceController").GetComponent<SenceController>().SetStepDetailsPanel1();
                break;
            case StepDetailNum.Step2:
                GameObject.Find("SenceController").GetComponent<SenceController>().SetStepDetailsPanel2();
                break;
            case StepDetailNum.Step3:
                GameObject.Find("SenceController").GetComponent<SenceController>().SetStepDetailsPanel3();
                break;
            case StepDetailNum.Step4:
                GameObject.Find("SenceController").GetComponent<SenceController>().SetStepDetailsPanel4();
                break;
        }
      
    }
}

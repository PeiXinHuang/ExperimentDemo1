using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * 场景一控制器：控制场景中物体的显示，以及实验进度
 */

public class SenceController : MonoBehaviour
{


    public GameObject purposeMenu;  //目的与要求界面
    public GameObject exStepsMenu; //实验步骤面板
    public GameObject controllerBtn; //实验步骤面板
    public GameObject StepDeatailsPanel1; //步骤一详情面板
    public GameObject StepDeatailsPanel2; //步骤二详情面板
    public GameObject StepDeatailsPanel3; //步骤三详情面板
    public GameObject StepDeatailsPanel4; //步骤四详情面板


     

    private GameObject pineRoot; //树根模型
    private GameObject pineFruit; //松果模型
    private GameObject microscope; //显微镜模型
    private GameObject pineFree; //松叶模型
    private GameObject glassSlide; //载玻片模型

    private bool isShowExStepsMenu = true; //是否显示操作面板

    private int microscopeDirection = 0; //显微镜转向
    

    // Start is called before the first frame update
    void Start()
    {

        pineRoot = (GameObject)Instantiate(Resources.Load("pineRootPrefab")); //加载树根模型
        pineFruit = (GameObject)Instantiate(Resources.Load("pineFruitPrefab")); //加载松果模型
        microscope = (GameObject)Instantiate(Resources.Load("microscopePrefab")); //加载显微镜模型
        pineFree = (GameObject)Instantiate(Resources.Load("pineLeafPrefab")); //加载松叶模型
        glassSlide = (GameObject)Instantiate(Resources.Load("glassSlidePrefab")); //加载松叶模型
        LeanTween.moveZ(glassSlide.gameObject, -10.0f, 0);
        //LeanTween.alpha(glassSlide.gameObject,0.0f , 0);
        //初始化UI
        for (int i = 0; i< StepDeatailsPanel1.transform.childCount; i++)
        {
            StepDeatailsPanel1.transform.GetChild(i).transform.localScale = new Vector3(0, 0, 0);
        }
        //初始化UI
        for (int i = 0; i < StepDeatailsPanel2.transform.childCount; i++)
        {
            StepDeatailsPanel2.transform.GetChild(i).transform.localPosition = new Vector3(250, StepDeatailsPanel2.transform.GetChild(i).transform.localPosition.y, 
                0);
        }
        for (int i = 0; i < StepDeatailsPanel3.transform.childCount; i++)
        {
            LeanTween.alpha(StepDeatailsPanel3.transform.GetChild(i).gameObject.GetComponent<RectTransform>(), 0.0f,
                0);
        }

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
        controllerBtn.SetActive(false);

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
        glassSlide.SetActive(false);


        glassSlide.gameObject.transform.position = new Vector3(glassSlide.gameObject.transform.position.x, glassSlide.gameObject.transform.position.y, - 10.0f);
    }


    //显示步骤一模型
    public void ShowExOneStep1()
    {
        ResetSence();
        exStepsMenu.SetActive(true);
        controllerBtn.SetActive(true);
        pineRoot.SetActive(true);
    }

    //显示步骤二模型
    public void ShowExOneStep2()
    {
        ResetSence();
        pineFree.SetActive(true);
        exStepsMenu.SetActive(true);
        controllerBtn.SetActive(true);

    }

    //显示步骤三模型
    public void ShowExOneStep3()
    {
        ResetSence();
        microscope.SetActive(true);
        exStepsMenu.SetActive(true);
        controllerBtn.SetActive(true);
    }

    //显示步骤四模型
    public void ShowExOneStep4()
    {
        ResetSence();
        exStepsMenu.SetActive(true);
        controllerBtn.SetActive(true);
        pineFruit.SetActive(true);
    }

    //设置详情一面板，如果已经显示面板，那么就隐藏，否之即反
    public void SetStepDetailsPanel1()
    {
        if (StepDeatailsPanel1.activeInHierarchy)
        {
            
            StepDeatailsPanel1.SetActive(false);

            for (int i = 0; i < StepDeatailsPanel1.transform.childCount; i++) //重置UI大小
            {
                StepDeatailsPanel1.transform.GetChild(i).transform.localScale = new Vector3(0, 0, 0); 
            }



        }
        else
        {
            StepDeatailsPanel1.SetActive(true);
            LeanTween.rotateAroundLocal(pineRoot.gameObject, Vector3.up,180, 0.5f);//播放模型旋转动画

            //播放UI动画

            float animDuration = 0.5f;
            for (int i = 0; i < StepDeatailsPanel1.transform.childCount; i++) //播放UI动画
            {
                LeanTween.scale(StepDeatailsPanel1.transform.GetChild(i).gameObject, new Vector3(1, 1, 1), animDuration * (i+1)).setEase(LeanTweenType.easeInOutBack); 

            }

        }
    }

    //设置详情二面板，如果已经显示面板，那么就隐藏，反之即反
    public void SetStepDetailsPanel2()
    {
        if (StepDeatailsPanel2.activeInHierarchy)
        {
            StepDeatailsPanel2.SetActive(false);

            for (int i = 0; i < StepDeatailsPanel2.transform.childCount; i++)
            {
                StepDeatailsPanel2.transform.GetChild(i).transform.localPosition = new Vector3(800, StepDeatailsPanel2.transform.GetChild(i).transform.localPosition.y,
                 0);
            }

        }
        else
        {
            StepDeatailsPanel2.SetActive(true);
            LeanTween.rotateAroundLocal(pineFree.gameObject, Vector3.up, 180, 0.5f);//播放模型旋转动画
            float animDuration = 0.5f;
            for (int i = 0; i < StepDeatailsPanel2.transform.childCount; i++) //播放UI动画
            {
                LeanTween.moveLocalX(StepDeatailsPanel2.transform.GetChild(i).gameObject, 0, animDuration * (i + 1)).setEase(LeanTweenType.easeInOutBack);

            }
        }
    }

    //设置详情三面板，如果已经显示面板，那么就隐藏，反之即反
    public void SetStepDetailsPanel3()
    {
        if (StepDeatailsPanel3.activeInHierarchy)
        {
            StepDeatailsPanel3.SetActive(false);
            
            //LeanTween.moveZ(glassSlide.gameObject, -10.0f, 0.5f);
            //LeanTween.alpha(glassSlide.gameObject, 0.0f, 0.5f);

            for (int i = 0; i < StepDeatailsPanel3.transform.childCount; i++)
            {
                LeanTween.alpha(StepDeatailsPanel3.transform.GetChild(i).gameObject.GetComponent<RectTransform>(), 0.0f,
                    0);
            }

        }
        else
        {
            StepDeatailsPanel3.SetActive(true);
            float animDuration = 1.0f;
            glassSlide.SetActive(true);
            LeanTween.moveZ(glassSlide.gameObject, -0.5f, 0.5f);
           
            // LeanTween.alpha(glassSlide.gameObject, 1.0f, 0.5f);

            for (int i = 0; i < StepDeatailsPanel3.transform.childCount; i++) //播放UI动画
            {
                LeanTween.alpha(StepDeatailsPanel3.transform.GetChild(i).gameObject.GetComponent<RectTransform>(),1.0f, 
                    animDuration * (i + 1)).setEase(LeanTweenType.easeInOutBack);

            }

        }
    }

    //设置详情四面板，如果已经显示面板，那么就隐藏，反之即反
    public void SetStepDetailsPanel4()
    {
        if (StepDeatailsPanel4.activeInHierarchy)
        {
            StepDeatailsPanel4.SetActive(false);
        }
        else
        {
            StepDeatailsPanel4.SetActive(true);
            LeanTween.rotateAroundLocal(pineFruit.gameObject, Vector3.up, 180, 0.5f);//播放模型旋转动画
            float animDuration = 1.0f;
            for (int i = 0; i < StepDeatailsPanel4.transform.childCount; i++) //播放UI动画
            {
                LeanTween.rotateAroundLocal(StepDeatailsPanel4.transform.GetChild(i).gameObject, Vector3.up, 360.0f , animDuration * (i + 1)).setEase(LeanTweenType.easeInOutBack);

            }
        }
    }

    //重置摄像机位置
    public void ResetCamera()
    {
        GameObject.Find("Main Camera").transform.position = new Vector3(0, 0, -10);
        GameObject.Find("Main Camera").transform.rotation = new Quaternion(0,0,0,0);
    }

    //隐藏实验步骤面板
    public void SetExStepsMenu()
    {
        if (isShowExStepsMenu)
        {
            
            //参数：移动的物体，移动的距离，移动的时间
            LeanTween.moveLocalX(exStepsMenu.gameObject, -159, 0.5f);
            exStepsMenu.gameObject.transform.Find("showExStepBtn").gameObject.transform.Find("image1").gameObject.SetActive(false);
            exStepsMenu.gameObject.transform.Find("showExStepBtn").gameObject.transform.Find("image2").gameObject.SetActive(true);
        }
        else
        {
            LeanTween.moveLocalX(exStepsMenu.gameObject, 0, 0.5f);
            exStepsMenu.gameObject.transform.Find("showExStepBtn").gameObject.transform.Find("image1").gameObject.SetActive(true);
            exStepsMenu.gameObject.transform.Find("showExStepBtn").gameObject.transform.Find("image2").gameObject.SetActive(false);
        }
        isShowExStepsMenu = !isShowExStepsMenu;
    }



    public void SetMicroscope()
    {
        GameObject image = StepDeatailsPanel3.transform.GetChild(0).transform.GetChild(0).gameObject;
        if (microscopeDirection == 0)
        {
            microscopeDirection = 1;
            image.GetComponent<Image>().sprite = Resources.Load("cellImg/cell2", typeof(Sprite)) as Sprite;
            LeanTween.alpha(image.GetComponent<RectTransform>(), 0.0f, 0);
            LeanTween.alpha(image.GetComponent<RectTransform>(), 1.0f, 1.0f);
            microscope.transform.GetChild(0).GetComponent<Animation>().Play("ani1");
        }
        else if (microscopeDirection == 1)
        {
            microscopeDirection = 2;

            image.GetComponent<Image>().sprite = Resources.Load("cellImg/cell1", typeof(Sprite)) as Sprite;
            LeanTween.alpha(image.GetComponent<RectTransform>(), 0.0f, 0);
            LeanTween.alpha(image.GetComponent<RectTransform>(), 1.0f, 1.0f);
            microscope.transform.GetChild(0).GetComponent<Animation>().Play("ani2");
        }
        else if (microscopeDirection == 2)
        {
            microscopeDirection = 0;
            image.GetComponent<Image>().sprite = Resources.Load("cellImg/cell3", typeof(Sprite)) as Sprite;
            microscope.transform.GetChild(0).GetComponent<Animation>().Play("ani3");
        }

    }

    //步骤三获取结论
    public void GetNote()
    {
        GameObject note = StepDeatailsPanel3.transform.GetChild(3).gameObject;
        if (note.activeInHierarchy)
        {
            note.SetActive(false);
        }
        else
        {
            note.SetActive(true);
            
        }
    }
}

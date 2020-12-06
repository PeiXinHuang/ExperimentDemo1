# 游戏开发原理实训项目总结



## 一、项目说明

用Unity实现虚拟仿真实验，实现线上实验功能

### 1、实验一：观察松树的根叶果
![01](ReadMeImage/image/01.png)
![02](ReadMeImage/image/02.png)
![03](ReadMeImage/image/03.png)





---






## 二、场景切换的实现

[参考教程](https://blog.csdn.net/yaoning6768/article/details/88083530)

> 实验步骤
>
> 1. 创建多个场景，在各个场景中创建场景跳转按钮，设置按钮文字大小样式等
> 2. 点击左上角的File-Build Settings，点击add open Scene，添加创建的几个场景
> 3. 编写跳转控制代码，将代码设置到按钮上面，输入要跳转的场景名称
> 4. 运行，实现场景的跳转



场景跳转代码

```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 * 场景跳转控制器
 * 设置在按钮上，点击按钮跳转到SenceName场景
 */

public class SenceChooseController : MonoBehaviour
{
    //获取要跳转的场景名称
    public string senceName;
    void Start()
    {
        //获取按钮后设置按钮点击执行函数OnButtonClick
        this.GetComponent<Button>().onClick.AddListener(OnButtonClick);
    }
    
    //按钮点击执行函数
    void OnButtonClick()
    {
        //切换到SenceName场景
        SceneManager.LoadScene(senceName);
    }
}

```

演示效果

![01](ReadMeImage/gif/01.gif)



---



## 三、UI界面设计

### 1、UI界面自适应屏幕问题

- 将Canvas的Canvas Scaler组件中的UI Scale Mode改为Scale With Screen Size
- 修改Canvas的子控件布局，设置子控件相对于屏幕某个地方的相对位置

效果如下
![01](ReadMeImage/gif/02.gif)





## 四、Unty简单动画效果

### 1、Unity加载Fbx模型及其动画

参考教程[百度经验](https://jingyan.baidu.com/article/63f23628c043b24209ab3d04.html)
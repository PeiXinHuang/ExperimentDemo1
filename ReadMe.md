# 游戏开发原理实训项目总结



## 一、项目说明

用Unity实现虚拟仿真实验，实现线上实验功能

### 1、实验一：观察松树的根叶果
![01](ReadMeImage/image/01.png)
![02](ReadMeImage/image/02.png)
![03](ReadMeImage/image/03.png)

### 2、实验二 探究串联电路中电压的规律

![01](ReadMeImage/image/04.png)

![01](ReadMeImage/image/05.png)

![01](ReadMeImage/image/06.png)

![01](ReadMeImage/image/07.png)

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



---

## 四、Unty简单动画效果

### 1、Unity加载Fbx模型及其动画

参考教程[百度经验](https://jingyan.baidu.com/article/63f23628c043b24209ab3d04.html)

### 2、添加脚本实现模型不停旋转效果

```c#
public int rotateSpeed = 0; //旋转速度，默认为0
this.transform.Rotate(Vector3.up * rotateSpeed); //绕上方轴旋转
```

实现效果：

![03](ReadMeImage/gif/03.gif)







----





## 五、摄像头控制

代码控制摄像头移动旋转缩放

```c#

    //移动旋转缩放速度
    public float translateSpeed = 5.0f;
    public float rotateSpeed = 5.0f;
    public float zoomSpeed = 0.5f；

    private void cameraRotate() //摄像机右键旋转
    {
       
        var mouse_x = Input.GetAxis("Mouse X");//获取鼠标X轴移动
        var mouse_y = -Input.GetAxis("Mouse Y");//获取鼠标Y轴移动
      
        if (Input.GetKey(KeyCode.Mouse2))
        {
            transform.Translate(Vector3.left * (mouse_x * rotateSpeed) * Time.deltaTime);
            transform.Translate(Vector3.up * (mouse_y * rotateSpeed) * Time.deltaTime);
        }
    }

    private void cameraTranslate() //摄像机中键平移
    {
        var mouse_x = Input.GetAxis("Mouse X");//获取鼠标X轴移动
        var mouse_y = -Input.GetAxis("Mouse Y");//获取鼠标Y轴移动

        if (Input.GetKey(KeyCode.Mouse1))
        {
            transform.RotateAround(new Vector3(0,0,0), Vector3.up, mouse_x * translateSpeed);
            transform.RotateAround(new Vector3(0, 0, 0), transform.right, mouse_y * translateSpeed);
        }
    }

    private void cameraZoom() //摄像机滚轮缩放
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
            transform.Translate(Vector3.forward * zoomSpeed);


        if (Input.GetAxis("Mouse ScrollWheel") < 0)
            transform.Translate(Vector3.forward * -1 * zoomSpeed);
    }
```



实现效果

![04](ReadMeImage/gif/04.gif)





---

## 六、Unity中物体的属性设置

### 1、给物体增加弹力 
 [简书](https://www.jianshu.com/p/5bf073d20298)

### 2、在某个位置创建物体

```c#
Instantiate(gameObject, position, gameobject.transform.rotation); 
```

### 3、鼠标拖拽模型的实现

参考教程： [unity3D物体跟着鼠标移动](https://blog.csdn.net/qq_34735841/article/details/101012513)

实现过程

1. 创建一个Cube，一个地面，设置好大小

2. 为Cube添加Rigidbody组件（可以在Rigidbod组件上禁止物体的旋转）

3. 设置拖拽代码到Cube上面

   ```C#
   private bool isDrag = false; //是否开始移动物体
   
   void Update()
   {
       if (isDrag)
       {
           //获取需要移动物体的世界转屏幕坐标
           Vector3 screenPos = Camera.main.WorldToScreenPoint(this.transform.position);
           //获取鼠标位置
           Vector3 mousePos = Input.mousePosition;
           //因为鼠标只有X，Y轴，所以要赋予给鼠标Z轴
           mousePos.z = screenPos.z;
           //把鼠标的屏幕坐标转换成世界坐标
           Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
   
           //防止物体移动到地面下方,模型坐标轴应该在物体中心
           if (worldPos.y < transform.localScale.y/2.0f) worldPos.y = transform.localScale.y / 2.0f;
           //控制物体移动
           transform.position = worldPos;
       }
   }
   private void OnMouseDown()
   {
       isDrag = true;
   
   }
   private void OnMouseUp()
   {
       isDrag = false;
   }
   ```

   

实现效果：

![05](ReadMeImage/gif/05.gif)
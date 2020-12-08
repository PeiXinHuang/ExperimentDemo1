using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * 摄像机控制类，通过鼠标控制摄像机绕原点中心的移动旋转缩放
 */

public class CameraController: MonoBehaviour
{

    //移动旋转缩放速度
    public float translateSpeed = 5.0f;
    public float rotateSpeed = 5.0f;
    public float zoomSpeed = 0.5f;


    private void Update()
    {
        cameraTranslate();
        cameraRotate();
        cameraZoom();
    }


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

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 *  该脚本用于控制模型不断旋转
 */
public class ModelRotateController : MonoBehaviour
{

    public int rotateSpeed = 0; //旋转速度，默认为0

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(Vector3.up * rotateSpeed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 电源控制器类，用于管理电源是否接通，并且触发电源接通后的事件
/// </summary>
public class switchController : MonoBehaviour
{
    private bool isConnect = false; //电源是否接通
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        isConnect = !isConnect;
        if (isConnect)
        {
            Debug.Log("接通电源");
            //Todo: 触发电源接通事件
   
        }
        else
        {
            Debug.Log("断开电源"); 
            //Todo: 触发电源事件

        }

    }

  
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * 场景二控制器
 */

public class ExTwoSenceController : MonoBehaviour
{
    public GameObject voltmeter; //电压表

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //创建电压表
    public void CreateVoltmeter()
    {
      
        GameObject gameObject = Instantiate(voltmeter, new Vector3(0,10,0), voltmeter.transform.rotation);
        

    }

}

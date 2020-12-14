using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //绑定按钮事件
        this.GetComponent<Button>().onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //根据按钮编号，执行按钮点击事件
    public void OnButtonClick()
    {
        //3个参数1.变换的物体，2变化内容，3.时间
        LeanTween.scale(this.gameObject, new Vector3(1, 2, 1), 0.5f);
        LeanTween.rotate(this.gameObject, new Vector3(0, 90, 90), 0.5f);
        LeanTween.move(this.gameObject, new Vector3(0, 2, 2), 0.5f);
    }
}

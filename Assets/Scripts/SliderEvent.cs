using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Video;

public class SliderEvent : MonoBehaviour,IDragHandler
{

    public GameObject slider;
    public GameObject video;
    public void OnDrag(PointerEventData eventData)
    {
        video.GetComponent<VideoPlayer>().time = slider.GetComponent<Slider>().value * video.GetComponent<VideoPlayer>().clip.length;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class SoundMan : MonoBehaviour
{
    [SerializeField]
    private Image image;
    [SerializeField]
    private Sprite normalMan;
    [SerializeField]
    private Sprite angryMan;

    [SerializeField]
    private Slider volumeslider;
    [SerializeField]
    private Slider soundslider;


    // Update is called once per frame
    void FixedUpdate()
    {
        if (volumeslider.value >= 8 && EventSystem.current.currentSelectedGameObject.name == "VolumeSlider"
            || soundslider.value >= 8 && EventSystem.current.currentSelectedGameObject.name == "SoundSlider")
        {
            image.sprite = angryMan;
        } else
        {
            image.sprite = normalMan;
        }
    }
}

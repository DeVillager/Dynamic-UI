using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SoundSettings : MonoBehaviour
{
    private int childCount;
    private int i = 0;

    void Start()
    {
        childCount = transform.childCount;
        EventSystem.current.SetSelectedGameObject(transform.GetChild(0).gameObject);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            i++;
            Debug.Log(i);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            i--;
            Debug.Log(i);
        }

        if (i >= childCount)
        {
            i = childCount - 1;
        }
        else if (i < 0)
        {
            i = 0;
        }

        EventSystem.current.SetSelectedGameObject(transform.GetChild(i).gameObject);
    }
}

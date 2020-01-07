using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RollMenu : MonoBehaviour
{
    private int childCount;
    [SerializeField]
    private int steps = 5;
    private int i = 0;
    private bool rollDone = true;
    private bool choosingDifficulty = true;
    // Start is called before the first frame update
    void Start()
    {
        childCount = transform.childCount;
        EventSystem.current.SetSelectedGameObject(transform.GetChild(i).gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow) && rollDone && choosingDifficulty)
        {

            StartCoroutine(SelectNext(Vector3.forward));
            i++;
            Debug.Log(i);
        }
        else if (Input.GetKey(KeyCode.UpArrow) && rollDone && choosingDifficulty)
        {
            StartCoroutine(SelectNext(Vector3.back));
            i--;
            Debug.Log(i);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && rollDone)
        {
            choosingDifficulty = false;
        }
        else if (Input.GetKey(KeyCode.RightArrow) && rollDone)
        {
            choosingDifficulty = true;
        }

    }


    IEnumerator SelectNext(Vector3 direction)
    {
        rollDone = false;
        float time = 0.4f;     //How long will the object be rotated?
        //EventSystem.current.SetSelectedGameObject(transform.GetChild(i).gameObject);
        while (time > 0)     //While the time is more than zero...
        {
            float angle = 360 / childCount / steps;
            transform.Rotate(direction * angle, Space.Self);
            time -= 0.1f;     //Decrease the time- value one unit per second.

            yield return null;     //Loop the method.
        }
        rollDone = true;
    }

    private void FixedUpdate()
    {
        if (i >= childCount)
        {
            i = 0;
        }
        else if (i < 0)
        {
            i = childCount - 1;
        }
        if (choosingDifficulty)
        {
            EventSystem.current.SetSelectedGameObject(transform.GetChild(i).gameObject);
        }
        else
        {
            EventSystem.current.SetSelectedGameObject(transform.parent.GetChild(1).gameObject);
        }
        
    }
}

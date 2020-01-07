using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectNext : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventSystem.current.SetSelectedGameObject(transform.parent.GetChild(0).gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (EventSystem.current.currentSelectedGameObject == gameObject)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                int i = transform.GetSiblingIndex();
                if (i < transform.parent.childCount - 1)
                {
                    EventSystem.current.SetSelectedGameObject(transform.parent.GetChild(i + 1).gameObject);
                }
                else
                {
                    EventSystem.current.SetSelectedGameObject(transform.parent.GetChild(0).gameObject);
                }
            }
            //if (Input.GetKeyDown(KeyCode.UpArrow))
            //{
            //    int i = transform.GetSiblingIndex();
            //    try
            //    {
            //        EventSystem.current.SetSelectedGameObject(transform.parent.GetChild(i - 1).gameObject);
            //    }
            //    catch (System.Exception)
            //    {
            //        EventSystem.current.SetSelectedGameObject(transform.parent.GetChild(0).gameObject);
            //    }
            //    //if (!EventSystem.current.currentSelectedGameObject)
            //    //{
            //    //}
            //    //else
            //    //{
            //    //    EventSystem.current.SetSelectedGameObject(transform.parent.GetChild(0).gameObject);
            //    //}
            //}

        }

    }
}

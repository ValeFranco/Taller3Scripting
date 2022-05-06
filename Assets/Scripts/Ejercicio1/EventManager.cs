using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public delegate void ClickAction();
    public static event ClickAction onClickedBtn1;
    public static event ClickAction onClickedBtn2;
    public static event ClickAction onClickedBtn3;
    // Start is called before the first frame update
    void OnGUI()
    {
        if (GUI.Button(new Rect(100, 850, 300, 100), "Tipo 1"))
        {
            if (onClickedBtn1 != null)
            {
                onClickedBtn1();
            }
        }
        if (GUI.Button(new Rect(800, 850, 300, 100), "Tipo 2"))
        {
            if (onClickedBtn2 != null)
            {
                onClickedBtn2();
            }
        }
        if (GUI.Button(new Rect(1500, 850, 300, 100), "Tipo 3"))
        {
            if (onClickedBtn3 != null)
            {
                onClickedBtn3();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

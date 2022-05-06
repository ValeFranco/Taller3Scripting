using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void ClickAction();
    public static event ClickAction onClickedBtn1;
    public static event ClickAction onClickedBtn2;
    public static event ClickAction onClickedBtn3;
    // Start is called before the first frame update
    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / -646, -410, 235, 83), "Tipo 1"))
        {
            if (onClickedBtn1 != null)
            {
                onClickedBtn1();
            }
        }else if (GUI.Button(new Rect(Screen.width / -14, -410, 235, 83), "Tipo 2"))
        {
            if (onClickedBtn2 != null)
            {
                onClickedBtn2();
            }
        }else if (GUI.Button(new Rect(Screen.width / 643, -410, 235, 83), "Tipo 3"))
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void ClickAction();
    public static event ClickAction onClicked;
    // Start is called before the first frame update
    void OnGUI() 
    {
        if(GUI.Button(new Rect(Screen.width / 2 -50, 5, 100, 30), "Tipo 1"))
        {
            if (onClicked != null)
            {
                onClicked();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

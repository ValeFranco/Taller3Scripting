using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public delegate void ClickAction();
    public static event ClickAction onClicked;
    
    // Start is called before the first frame update
    void Update()
    {
        
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(800, 850, 300, 100), "Tipo 2"))
        {
            if (onClicked != null)
            {
                onClicked();
            }
        }
    }
}

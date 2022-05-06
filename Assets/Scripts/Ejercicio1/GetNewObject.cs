using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetNewObject : MonoBehaviour
{
   
    void OnEnable()
    {
        EventManager.onClicked += NewObject;
    }
    void OnDisable()
    {
        EventManager.onClicked -= NewObject;
    }

    void NewObject()
    {
       //client.GetNewObject(objectType);
    }
}

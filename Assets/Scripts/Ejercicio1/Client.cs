using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
     private FactoryFacade factory;

    private GameObject lastObject;

    void Awake()
    {
        factory = GetComponent<FactoryFacade>();
    }
    public void GetNewObject()
    {
        if(lastObject != null)
        {
            Destroy(lastObject);
        }
        lastObject = factory?.ObtenerObjeto();
        lastObject.transform.position = transform.position;
    }
    public void ClickButton()
    {
        factory.ObtenerObjeto();
    }
}

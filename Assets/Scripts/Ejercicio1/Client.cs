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
    public void GetNewObject(ObjectType objectType)
    {
        if(lastObject != null)
        {
            Destroy(lastObject);
        }
        lastObject = factory?.GetNewObject(objectType);
        lastObject.transform.position = transform.position;
    }
}

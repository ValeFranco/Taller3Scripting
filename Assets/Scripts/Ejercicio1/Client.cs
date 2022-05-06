using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    [SerializeField] private FactoryFecade factory;

    private GameObject lastObject;

    void Update()
    {
        
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

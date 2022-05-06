using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ObjectType
{
    FristObject,
    SecondObject,
    ThridObject
}
public class FactoryFacade : MonoBehaviour
{
    
    [SerializeField]
    private IFactory firstFactory;

    [SerializeField]
    private IFactory secondFactory;

    [SerializeField]
    private IFactory thridFactory;

    

    public GameObject GetNewObject(ObjectType objectType)
    {

        GameObject result = null;

        switch (objectType)
        {
            case ObjectType.FristObject:
                result = firstFactory?.GetNewObject();
                break;

            case ObjectType.SecondObject:
                result = secondFactory?.GetNewObject();
                break;

            case ObjectType.ThridObject:
                result = thridFactory?.GetNewObject();
                break;
        }

        return result;
    }
  
}

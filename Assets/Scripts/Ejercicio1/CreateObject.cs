using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    private FactoryFacade facade;
    public static int contador { get; private set; } = 1;
    private void Awake()
    {
        facade = GetComponent<FactoryFacade>();
    }

    void Start()
    {
        if (contador ==1)
        {
            EventManager.onClicked += CreateObjectType1;
        }
        
        //EventManager.onClickedBtn2 += CreateObjectType2;
        //EventManager.onClickedBtn3 += CreateObjectType3;
    }

    void CreateObjectType1()
    {
        facade.GetNewObject(ObjectType.FristObject);
    }
    void CreateObjectType2()
    {
        facade.GetNewObject(ObjectType.SecondObject);
    }
    void CreateObjectType3()
    {
        facade.GetNewObject(ObjectType.ThridObject);
    }
}

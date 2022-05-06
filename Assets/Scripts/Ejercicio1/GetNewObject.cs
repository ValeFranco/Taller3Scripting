using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewObject : MonoBehaviour
{
    private FactoryFacade facade;

    private void Awake()
    {
        facade = GetComponent<FactoryFacade>();
    }

    void OnEnable()
    {
        EventManager.onClickedBtn1 += CreateObjectType1;
        EventManager.onClickedBtn2 += CreateObjectType2;
        EventManager.onClickedBtn3 += CreateObjectType3;
    }
    void OnDisable()
    {
        EventManager.onClickedBtn1 -= CreateObjectType1;
        EventManager.onClickedBtn2 -= CreateObjectType2;
        EventManager.onClickedBtn3 -= CreateObjectType3;
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

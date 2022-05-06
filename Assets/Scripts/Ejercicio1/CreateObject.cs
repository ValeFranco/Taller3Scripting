using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    private FactoryFacade facade;
    public static int Contador { get; private set; } = 1;
    private void Awake()
    {
        facade = GetComponent<FactoryFacade>();
    }

    void Start() => EventManager.OnClicked += CyclicChange;

    void CyclicChange()
    {
        Contador = Contador == 3 ? 1 : Contador;
        Contador++;

        CreateObjectType(Contador);
    }
    void CreateObjectType(int enumNumber)
    {
        ObjectType objectType = (ObjectType)enumNumber;
        facade.GetNewObject(objectType);
    }
 
}

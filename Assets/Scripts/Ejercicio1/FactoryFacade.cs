using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryFacade : MonoBehaviour
{ 
    private FirstObject firstFactory;
 
    private SecondObject secondFactory;

    private ThirdObject thirdObject;

    int caso = 1;

    private void Awake()
    {
        firstFactory = GetComponent<FirstObject>();
        secondFactory= GetComponent<SecondObject>();
        thirdObject = GetComponent<ThirdObject>();
    }

    public GameObject ObtenerObjeto()
    {

        GameObject result = null;

        switch (caso)
        {
            case 1:
                result = firstFactory?.GetNewObject();
                caso++;
                break;

            case 2:
                result = secondFactory?.GetNewObject();
                caso++;
                break;

            case 3:
                result = thirdObject?.GetNewObject();
                caso = 1;
                break;
        }

        return result;
    }
  
}

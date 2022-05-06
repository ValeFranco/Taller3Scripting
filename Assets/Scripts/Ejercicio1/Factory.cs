using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Factory : MonoBehaviour, IFactory

{
    [SerializeField]
    private GameObject template;
   
    public GameObject GetNewObject()
    {
        GameObject instance = Instantiate(template);
        return instance;
    }

}

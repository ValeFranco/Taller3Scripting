using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MandonColorChanger : MonoBehaviour
{
    Renderer renderer;
    [SerializeField] Material[] differentColorMaterials = new Material[4];
    private void Awake() => renderer = GetComponent<Renderer>();
    private void Start() => MandonEventManager.OnButtonClicked += ChangeColor;
    void ChangeColor() => renderer.material = differentColorMaterials[MandonEventManager.cyclicCounter-1];

}

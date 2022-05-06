using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MandonEventManager : MonoBehaviour
{
    public delegate void MyClickAction();
    public static event MyClickAction OnButtonClicked;
    public static int cyclicCounter { get; private set; } = 1; //this should always be initialized in 1

    void Start() => OnButtonClicked += CyclicNumberCounter;

    void Update() => MouseInput();
    void MouseInput() { if (Input.GetMouseButtonDown(0)) OnButtonClicked?.Invoke(); }

    void CyclicNumberCounter()
    {
        cyclicCounter = cyclicCounter == 4 ? cyclicCounter = 1 : cyclicCounter;
        cyclicCounter++;
    }

}

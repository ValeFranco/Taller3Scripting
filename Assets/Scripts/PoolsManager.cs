using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolsManager : MonoBehaviour
{
    [SerializeField] public static bool IsInputDisabled = false;

    [SerializeField] ProjectilePool myBulletPool1, myBulletPool2, myBulletPool3;

    int poolCyclicSwitcher = 1;

    private void Start()
    {
        myBulletPool1 = GameObject.Find("Pool1").gameObject.GetComponent<ProjectilePool>();
        myBulletPool2 = GameObject.Find("Pool2").gameObject.GetComponent<ProjectilePool>();
        myBulletPool3 = GameObject.Find("Pool3").gameObject.GetComponent<ProjectilePool>();

        myBulletPool1.enabled = true;
        myBulletPool2.enabled = false;
        myBulletPool3.enabled = false;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(1)) //change pool
        {
            PoolSwitcher();

            Debug.Log(poolCyclicSwitcher);

            switch (poolCyclicSwitcher)
            {
                case 1:
                    myBulletPool1.enabled = true;
                    myBulletPool2.enabled = false;
                    myBulletPool3.enabled = false;
                    break;

                case 2:
                    myBulletPool1.enabled = false;
                    myBulletPool2.enabled = true;
                    myBulletPool3.enabled = false;
                    break;

                case 3:
                    myBulletPool1.enabled = false;
                    myBulletPool2.enabled = false;
                    myBulletPool3.enabled = true;
                    break;
            }

         
        }
    }
    void PoolSwitcher()
    {
        poolCyclicSwitcher = poolCyclicSwitcher == 3 ? 1 : poolCyclicSwitcher;
        poolCyclicSwitcher++;
    }




}

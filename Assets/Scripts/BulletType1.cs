using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletType1 : Bullet
{
    public override void OnImpactDo()
    {
        Debug.Log("Projectil 1 ha impactado!");
        gameObject.SetActive(false);
    }

}

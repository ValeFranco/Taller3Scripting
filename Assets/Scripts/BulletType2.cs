using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletType2 : Bullet
{
    public override void OnImpactDo()
    {
        Debug.Log("Bullet 2 impacted");
        PoolsManager.IsInputDisabled = true;
    }
    
}

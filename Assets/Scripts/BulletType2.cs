using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletType2 : Bullet
{
    public override void OnImpactDo()
    {
        StartCoroutine(disableInputFor1Second());
        GetComponent<Collider>().enabled = false;
    }
    IEnumerator disableInputFor1Second()
    {
        PoolsManager.IsInputDisabled = true;
        yield return new WaitForSeconds(0.5f);
        PoolsManager.IsInputDisabled = true;
        GetComponent<Collider>().enabled = true;
        gameObject.SetActive(false);


    }
}

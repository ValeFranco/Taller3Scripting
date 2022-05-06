using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletType3 : Bullet
{
    private void Start()
    {
        GetComponent<ParticleSystem>().Stop();
    }
    public override void OnImpactDo()
    {
        StartCoroutine(PlayFor1Second());
    }

    IEnumerator PlayFor1Second()
    {
        GetComponent<ParticleSystem>().Play();
        yield return new WaitForSeconds(1f);
        GetComponent<ParticleSystem>().Stop();
        gameObject.SetActive(false);

    }
}

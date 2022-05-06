using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ProjectilePool : MonoBehaviour
{
    //public static ProjectilePool SharedInstance; 
    public List<GameObject> BulletsPooled;

    [SerializeField] GameObject bulletToPool;


    [SerializeField] int poolSize;

    //private void Awake() => SharedInstance = this;

    void Start()
    {
        BulletsPooled = new List<GameObject>();
        GameObject temporalBullet;

        for (int i = 0; i < poolSize; i++)
        {
            temporalBullet = Instantiate(bulletToPool);
            temporalBullet.SetActive(false);
            BulletsPooled.Add(temporalBullet);
        }

    }

    // Update is called once per frame
    void Update()
    {
        shootBulletManager();

    }

    GameObject GetPooledBullet()
    {
        for (int i = 0; i < poolSize; i++)
        {
            if (!BulletsPooled[i].activeInHierarchy)
            {
                return BulletsPooled[i];
            }
        }
        return null;
    }

    void shootBulletManager()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject bullet = GetPooledBullet();

            if (bullet != null)
            {
                bullet.transform.position = this.transform.position;
                bullet.transform.rotation = this.transform.rotation;

                bullet.SetActive(true);
            }
        }
    }

    void deactivateThisPool()
    {

    }
}

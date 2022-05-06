using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
   Rigidbody rb;
    [SerializeField] float thrustForce = 50f;
    private void Awake() => rb = GetComponent<Rigidbody>();
    private void Start() => rb.AddForce(Vector3.forward * thrustForce, ForceMode.Force);

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag!="Bullet")
        {   
            OnImpactDo();
        }
    }
    public abstract void OnImpactDo();
}

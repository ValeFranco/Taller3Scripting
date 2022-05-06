using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
   Rigidbody rb;
    [SerializeField] float thrustForce = 2f;
    private void Awake() => rb = GetComponent<Rigidbody>();

    private void Update()
    {
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, thrustForce/3);
        rb.AddForce(Vector3.forward * thrustForce/3, ForceMode.VelocityChange);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Target")
        {   
            OnImpactDo();
        }
    }
    public abstract void OnImpactDo();
}

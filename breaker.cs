using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class breaker : MonoBehaviour
{
    public GameObject fractured;
    public float breakforce;
    public GameObject smokeEffect;

    void OnTriggerEnter(Collider otherObj)
    {
        if (otherObj.gameObject.tag == "chisel")
        {
            BreakObject();
            Smoker();
        }
    }

    public void BreakObject()
    {
        GameObject frac = Instantiate(fractured, transform.position, transform.rotation);

        foreach (Rigidbody rb in frac.GetComponentsInChildren<Rigidbody>())
        {
            Vector3 force = (rb.transform.position - transform.position).normalized * breakforce;
            rb.AddForce(force);
        }
        Destroy(gameObject);
    }

    public void Smoker()
    {
        Instantiate(smokeEffect, transform.position, transform.rotation);
    }
}

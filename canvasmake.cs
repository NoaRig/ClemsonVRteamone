using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasmake : MonoBehaviour
{
    public GameObject fractured;
    public GameObject smokeEffect;

    void OnTriggerEnter(Collider otherObj)
    {
        if (otherObj.gameObject.tag == "brush")
        {
            StartCoroutine(paint());
        }
    }

    IEnumerator paint()
    {
        Smoker();
        yield return new WaitForSeconds(.5f);
        BreakObject();
    }


    public void BreakObject()
    {
        GameObject frac = Instantiate(fractured, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    public void Smoker()
    {
        Instantiate(smokeEffect, transform.position, transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class museumaudio : MonoBehaviour
{
    public AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "item")
            source.Play();
    }


}

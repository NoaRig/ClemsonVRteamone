using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grassaudio : MonoBehaviour
{
    public AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider grasscollision)
    {
        if (grasscollision.tag == "brush")
            source.Play();
        if (grasscollision.tag == "chisel")
            source.Play();
    }

}

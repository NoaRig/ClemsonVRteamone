using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impact : MonoBehaviour
{

    public AudioClip impact1;
    public AudioClip impact2;
    public AudioClip impact3;
    public AudioClip impact4;
    public AudioClip impact5;
    public int rand;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        
        GetComponent<AudioSource>().clip = impact1;
    }

    // Update is called once per frame
    void OnCollisionEnter()
    {

        rand = Random.Range(1, 6);
        if(rand == 1)
        {
            GetComponent<AudioSource>().clip = impact1;
        }
        if (rand == 2)
        {
            GetComponent<AudioSource>().clip = impact2;
        }
        if (rand == 3)
        {
            GetComponent<AudioSource>().clip = impact3;
        }
        if (rand == 4)
        {
            GetComponent<AudioSource>().clip = impact4;
        }
        if (rand == 5)
        {
            GetComponent<AudioSource>().clip = impact5;
        }
        GetComponent<AudioSource>().Play();
    }


}

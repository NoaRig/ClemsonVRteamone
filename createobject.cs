using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CreateObject : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject Prefab;
    //Keeps track of gun's ability to shoot.
    public bool canShoot = true;
    
    void Update()
    {   //Only allow for shooting after at least a half second has passed since the last shot.
        if((Input.GetKeyDown("f")) && (canShoot == true))
        {
            //Spawn bullet, the bullet itself has it's trajectory all worked out.
            Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
            //Begin the timer for the bullet firing.
            StartCoroutine("StopGunFire");
            //Disallow firing
            canShoot = false;
        }
    }

    //Subroutine responsible for handling firerate counter.
    IEnumerator StopGunFire()
    {   //Wait for .5 seconds
        yield return new WaitForSeconds(0.5f);
        //Allow firing
        canShoot = true;
        //End coroutine to optimise game.
        StopCoroutine("StopGunFire");
    }
}

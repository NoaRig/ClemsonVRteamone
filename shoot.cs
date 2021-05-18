using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public Rigidbody BulletBill; //The rigidbody that will be used as the bullet.
    public float speed = 20; //How fast the bullet will travel in forward direction.
    public bool waitongun; //Boolean feature to allow for the time to wait.

    // Update is called once per frame. this function will wait on the input of the spacbar and will then use the Coroutine which is an assignment requirement.
    void Update()
    {
        if ((Input.GetKeyDown("f")) && (!waitongun))
        {
            StartCoroutine(Blast()); // Statring the coroutine here for the Ienumerator blast.
        }
    }

    //This section of code is what deals with the waiting of the bullet being fired.
    IEnumerator Blast()
    {
        waitongun = true; // Set the wait to true.
        ShotsWillFire(); // Use the fireing function that instantiates and send bullet.
        yield return new WaitForSeconds(.5f);// Wait the half second so that two bulllets can fire each second as stated in requirements.
        waitongun = false; // Set the gun to false.
       
    }


    // This is the function responsible for instantiating the object as well as sending it forward with velocity.
    public void ShotsWillFire()
    {
        Rigidbody instantiatedProjectile = Instantiate(BulletBill, transform.position, transform.rotation) as Rigidbody; // Instantiate the rigidbody.
        instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed)); // Send the rigidbody in a forward direction.
    }

}

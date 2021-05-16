using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarShooting : MonoBehaviour
{
    // Determines the starting position of the bullet.
    public Transform fireStartPoint;

    //The bullet prefab that will be used.
    public GameObject bullet;

    //The speed of the bullet
    public float speed = 25f;


    // Update is called once per frame
    void Update()
    {
        // If the player clicks on the space bar, the shooting function is executed.
        if (Input.GetKeyDown("space"))
        {
            PlayerShoot();
        }
    }

    void PlayerShoot() 
    {
        // Spawn the bullet prefab as a game object called b
        // That object will be spawned on the fireStartPoint position.
        // he bullet will have no rotation.
        GameObject b = Instantiate(bullet, fireStartPoint.position, Quaternion.identity);

        // Selects the rigidbody linked to the bullet and saves it under the name rb3d.
        Rigidbody rb3d = b.GetComponent<Rigidbody>();

        // Adds a force to the Rigidbody rb3d.
        // The force is applied to the forward position (z axis) of the starting point, times the specified speed.
        // Adds an immediate force movement to the rigidbody, using its mass.
        rb3d.AddForce(fireStartPoint.forward * speed, ForceMode.Impulse);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider.
    // The other collider/rigidbody that is touched is saved in collision
    void OnCollisionEnter(Collision collision)
    {
        //Detects if the collider/rigidbody being touched has the tag Enemy.
        if (collision.gameObject.tag == "Enemy")
        {
            //Deletes the other game object if so.
            Destroy(collision.gameObject);
        }

        //Removes the bullet from the game
        Destroy(gameObject);
    }
}

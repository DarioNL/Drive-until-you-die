using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        //Detects if the bullet has moved off the map.
        if (gameObject.transform.position.z > 43)
        {
            //If so, the bullet is removed from the game.
            Destroy(gameObject);
        }
    }

    // When a GameObject collides with another GameObject, Unity calls OnTriggerEnter.
    // The other collider/rigidbody that is touched is saved in other.
    private void OnTriggerEnter(Collider other)
    {
        //Detects if the collider/rigidbody being touched has the tag Enemy.
        if (other.gameObject.tag == "Enemy")
        {
            //Deletes the other game object if so.
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Tree")
        {
            //If the bullet hits an object with the tag tree, the bullet is removed but the other object is left alone.
            Destroy(gameObject);
        }

        //Removes the bullet from the game
        Destroy(gameObject);
    }
}

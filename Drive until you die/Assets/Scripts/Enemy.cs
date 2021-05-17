using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{ 

    // Update is called once per frame
    void Update()
    {
        //Detects if the enemy has left the road.
        if (gameObject.transform.position.z < -43.6f)
        {
            //If so, the enemy is removed.
            Destroy(gameObject);
        }
    }

    

    // When a GameObject collides with another GameObject, Unity calls OnTriggerEnter.
    // The other collider/rigidbody that is touched is saved in other.
    private void OnTriggerEnter(Collider other)
    {
        //Detects if the collider/rigidbody being touched has the tag Player.
        if (other.gameObject.tag == "Player")
        {
            //Deletes the other game object if so.
            Destroy(other.gameObject);
            SceneManager.LoadScene("GameOver");
        }

        //Removes the Enemy from the game
        Destroy(gameObject);
    }
}

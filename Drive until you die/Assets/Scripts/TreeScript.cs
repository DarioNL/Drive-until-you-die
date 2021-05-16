using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour
{
    //Determines how fast the trees move.
    public float TreeStartSpeed = 10f;

    //Used to store the rigid body of the tree.
    private Rigidbody rb3d;

    // Start is called before the first frame update
    void Start()
    {
        //Saves the rigidbody of the tree in rb3d.
        rb3d = gameObject.GetComponent<Rigidbody>();

        //Adds velocity to the tree determined by the given amount.
        rb3d.velocity = new Vector3(0, 0.5f, -TreeStartSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        //Detects if the tree has gone off the road.
        if (gameObject.transform.position.z < -43.6f)
        {
            //If so, the tree is removed from the game.
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Detects if the collider/rigidbody being touched has the tag Player.
        if (other.gameObject.tag == "Player")
        {
            //Deletes the other game object if so.
            Destroy(other.gameObject);

            //Removes the Tree from the game
            Destroy(gameObject);
        }


    }
}
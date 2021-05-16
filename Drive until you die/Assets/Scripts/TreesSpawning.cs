using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreesSpawning : MonoBehaviour
{
    ////The prefab to be used for the tree.
    public GameObject TreePrefab;

    //The time between spawning new trees.
    public float SpawingTime = 5f;

    //The x axis where the left tree should spawn
    public float minX = -24.9f;

    //The x axis where the right tree should spawn
    public float maxX = 24.9f;

    // Start is called before the first frame update
    void Start()
    {
        //Starts the newTrees Coroutine.
        StartCoroutine(newTrees());
    }

    //The function that spawns the trees.
    private void SpawnTrees()
    {
        //Creates a new game object with the left tree prefab and stores it in t1.
        GameObject t1 = Instantiate(TreePrefab) as GameObject;

        //Creates a new game object with the right tree prefab and stores it in t2.
        GameObject t2 = Instantiate(TreePrefab) as GameObject;

        //Adds the velocity to the left tree based on the given speed.
        t1.transform.position = new Vector3(minX, 0.1f, 44f);

        //Adds the velocity to the left tree based on the given speed.
        t2.transform.position = new Vector3(maxX, 0.1f, 44f);
    }

    //A coroutine is like a function that has the ability to pause execution and return control to Unity but then to continue where it left off on the following frame.
    IEnumerator newTrees()
    {
        // //It continues to run until it is switched off.
        while (true)
        {
            //It waits for the specified number of seconds before executing the code.
            yield return new WaitForSeconds(SpawingTime);

            //Calls the function SpawnTrees.
            SpawnTrees();
        }
    }
}

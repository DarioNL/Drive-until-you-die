using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    //The prefab to be used for the enemy.
    public GameObject EnemyPrefab;

    //The time between spawning new enemies.
    public float SpawingTime = 5f;

    //The maximum x-axis at which the enemy may spawn.
    public float maxX;

    //The minimum x-axis at which the enemy may spawn.
    public float minX;

    //The speed of the cars at the beginning of the game.
    public float EnemyStartSpeed = 10f;

    //How fast the speed of the enemy should increase.
    public float speedMutiplier = 1f;

    //How quickly the time between enemy spawns should decrease.
    public float spawnSubstractor = 0.1f;

    //A variable to hold the rigidbody of the enemy.
    private Rigidbody rb3d;


    // Start is called before the first frame update
    void Start()
    {
        //Starts the newCar Coroutine.
        StartCoroutine(newCar());

        //Starts the speed Coroutine.
        StartCoroutine(speed());
    }

    //The function that spawns the enemies.
    private void SpawnEnemy()
    {
        //Selects a random value between minX and maxX
        float randomX = Random.Range(maxX, minX);

        //Creates a new game object with the enemy prefab and stores it in e.
        GameObject e = Instantiate(EnemyPrefab) as GameObject;

        //Set the new enemy to the correct start position.
        e.transform.position = new Vector3(randomX, 1.5f, 44f);

        //Selects the Rigidbody of the enemy and saves it in rb3d.
        rb3d = e.GetComponent<Rigidbody>();

        //Adds the velocity to the enemy based on the given speed.
        rb3d.velocity = new Vector3(0, 0, -EnemyStartSpeed);
    }

    //A coroutine is like a function that has the ability to pause execution and return control to Unity but then to continue where it left off on the following frame.
    IEnumerator newCar()
    {
        //It continues to run until it is switched off.
        while (true)
        {
            //It waits for the specified number of seconds before executing the code.
            yield return new WaitForSeconds(SpawingTime);

            //Calls the function SpawnEnemy.
            SpawnEnemy();
        }
    }

    //A coroutine is like a function that has the ability to pause execution and return control to Unity but then to continue where it left off on the following frame.
    IEnumerator speed()
    {
        //It continues to run until it is switched off.
        while (true)
        {
            //It waits for 1 second before executing the code.
            yield return new WaitForSeconds(1);

            //Adds the speed mutiplier to the speed of newly spawned enemies.
            EnemyStartSpeed += speedMutiplier;

            //Subtracts the spawn subtractor from the spawn time of new enemies.
            SpawingTime -= spawnSubstractor;
        }
    }
}

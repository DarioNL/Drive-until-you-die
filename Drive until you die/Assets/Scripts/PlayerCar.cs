using UnityEngine;

public class PlayerCar : MonoBehaviour
{
    //Determines the speed of the car
    public float speed;


    // Update is called once per frame
    void Update()
    {
         // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float xDirection = Input.GetAxisRaw("Horizontal");
        float zDirection = Input.GetAxisRaw("Vertical");

        
        if(gameObject.transform.position.x >= 27.5f) 
        {
            gameObject.transform.position = new Vector3(27.5f, 0, transform.position.z);
        } 
        else if(gameObject.transform.position.x <= -27.5f) 
        {
            gameObject.transform.position = new Vector3(-27.5f, 0, transform.position.z);
        }

        if (gameObject.transform.position.z >= 26)
        {
            gameObject.transform.position = new Vector3(transform.position.x, 0, 26);
        }
        else if (gameObject.transform.position.z <= -26)
        {
            gameObject.transform.position = new Vector3(transform.position.x, 0, -26);
        }

        //Representation of 3D vectors and points.
        //It adjusts the position of z and x axis of the car with the input times the speed
        gameObject.transform.position = new Vector3(transform.position.x + (xDirection * speed), 0,
      transform.position.z + (zDirection * speed));
    }
}

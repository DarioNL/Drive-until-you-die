using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    //The speed the map should go.
    public float scrollZ = 10f;

    // Update is called once per frame
    void Update()
    {
        //Ensures that the position keeps changing as long as the time runs.
        float Roadscroll = Time.time * scrollZ;

        //Makes the map scroll
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0f, -Roadscroll);
    }
}

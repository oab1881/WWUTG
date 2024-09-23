using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipping : MonoBehaviour
{
    //Script that allows the player to press space and flip between the view of the real world and AR world
    private GameObject[] ATagObjects; // Store references to all objects tagged "A" - Real World
    private GameObject[] BTagObjects; // Store references to objects tagged "B" - AR World

    void Start()
    {
        // Initialize the array once at the start
        ATagObjects = GameObject.FindGameObjectsWithTag("A");
        BTagObjects = GameObject.FindGameObjectsWithTag("B");

        //Start with all B objects inactive
        foreach (GameObject obj in BTagObjects)
        {
            obj.SetActive(false);
        }
    }

    void Update()
    {
        //Check if Space is pressed to flip between world views
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Toggle all A objects
            foreach (GameObject obj in ATagObjects)
            {
                bool isActive = obj.activeSelf;
                obj.SetActive(!isActive); // Toggle the active state
            }
            //Toggle all B objects
            foreach (GameObject obj in BTagObjects)
            {
                bool isActive = obj.activeSelf;
                obj.SetActive(!isActive); // Toggle the active state
            }

            //Debug.Log("Space was pressed.. Array length: " + ATagObjects.Length);
        }
    }
}

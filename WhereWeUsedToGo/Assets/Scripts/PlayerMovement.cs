using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 movement;

    [SerializeField]
    float speed;

    // Update is called once per frame
    void Update()
    {
        movement = Vector3.zero;
        //Will move the player to left multiplyed by speed and delta time
        if (Input.GetKey(KeyCode.A))
        {
            movement += Vector3.left.normalized * Time.deltaTime;
        }
        //For right movement
        if (Input.GetKey(KeyCode.D))
        {
            movement += Vector3.right.normalized * Time.deltaTime;
        }
        //For up movement
        if (Input.GetKey(KeyCode.W))
        {
            movement += Vector3.up.normalized * Time.deltaTime;

        }
        //For down movement
        if (Input.GetKey(KeyCode.S))
        {
            movement += Vector3.down.normalized * Time.deltaTime;
        }

        //clamping the magnitude of movement
        transform.position += Vector3.ClampMagnitude(movement * speed, speed);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed = 10;
    public float turningSpeed = 60;

    void Update()
    {


        //The orginal script should look like this: 
        ////float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        ////transform.Rotate(0, horizontal, 0);
        //but I edit so it can be working with the MouseCamera script

        float horizontal = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        transform.Translate(horizontal, 0,0 );

        float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical);
    }
}

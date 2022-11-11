using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoboterMovement : MonoBehaviour
{

//Variables
public float playerSpeed;
Rigidbody robot;


    // Start is called before the first frame update
    void Start()
    {
         //Physik
         robot = GetComponent<Rigidbody>();

        //Variables
        playerSpeed=5f;
        
       
       
    }

    // Update is called once per frame
    void Update()
    {
         //if W is pressed
         if (Input.GetKeyDown(KeyCode.W))
                {
                  transform.position += Vector3.forward;
                }
         //if S is pressed
        if (Input.GetKeyDown(KeyCode.S))
                {
                  transform.position += Vector3.back;
                }

        //if A is pressed
        if (Input.GetKeyDown(KeyCode.A))
                {
                  transform.position += Vector3.left;

                 
                }
        //if D is pressed
        if (Input.GetKeyDown(KeyCode.D))
                {
                  transform.position += Vector3.right;
                }




        //Jump
        if (Input.GetKeyDown("space"))
         {
            robot.velocity = new Vector3(0,5f,0);
         }






    }
}

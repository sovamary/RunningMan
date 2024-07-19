using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour
{
    private int speed = 20;
    private float horizontal;
    private float vertical;
    private int rotationSpeed = 80;
  

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        
        
        
        //if (gameOver == false)
       //{

        // }

        /* if (Input.GetKey(KeyCode.W))
             {
             transform.Translate(Vector3.forward * Time.deltaTime * speed);
         }

         if (Input.GetKey(KeyCode.S))
         {
             transform.Translate(Vector3.back * Time.deltaTime * speed);
         }

         if (Input.GetKey(KeyCode.A))
         {
             transform.Translate(Vector3.left * Time.deltaTime * speed);
         }
         if (Input.GetKey(KeyCode.D))
         {
             transform.Translate(Vector3.right * Time.deltaTime * speed);
         }*/

        transform.Translate(Vector3.forward * Time.deltaTime * speed*vertical);
        // transform.Translate(Vector3.right * Time.deltaTime * speed*horizontal);
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * horizontal);

    }

  /*  private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
    }

        
    }*/





}

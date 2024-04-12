using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour
{
    private int speed = 20;

    public bool gameOver;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  //if (gameOver == false)
        //{
            
       // }

        if (Input.GetKey(KeyCode.W))
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
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using UnityEngine;
using Vuforia;

public class snail_move2 : MonoBehaviour
{

    public Vector3 targetPosition;
    public float speed=10;
    public VirtualButtonBehaviour Vb;
    private volatile bool pressed = false;
    public string test = "hello";
    public static Task timer = Task.Run(async delegate {
        await Task.Delay(5000);
    });

    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);
    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        pressed = false;
        Debug.Log("button pressed");
        
        for (int i = 1; i <= 10000 ; i++)
        {
            //Debug.Log("about to wait");
            timer.Wait();            
            //My Processing Commands are Here 
            Debug.Log($"count: {i}");
            
            if (pressed)
            {
                Debug.Log("breaking loop");
                //pressed=false;
                break;
            }

            Debug.Log($"current state: {pressed}");

        }

        
        //int x = 1;
        //Debug.Log("entering while loop");
        // while (pressed == true)
        // {
        //     Debug.Log($"error: {x}");
        //     //transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        // }
        
        //Debug.Log("moving snail");
        
    }

    // public void MoveSnail()
    // {
    //     int x = 1;
    //     while (x<100)
    //     {
    //         Debug.Log($"error: {x}");
    //         x++;
    //     }
    // }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        pressed = true;
        Debug.Log("button released");
        Debug.Log($"current state: {pressed}");


    }
    
}

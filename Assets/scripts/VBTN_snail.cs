using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBTN_snail : MonoBehaviour
{
    // public Animator snailMove;
    //public GameObject cylinder;
    public Animator move;
    //public Rigidbody rb;
    public VirtualButtonBehaviour Vb;
    public GameObject nextButton;
    public GameObject repeatButton;
    public GameObject panel;
    public GameObject bubble;
    public volatile bool buttonPressed = false;
    public bool missionComplete = false;
    public float startTime;

    //Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);
        //cylinder.SetActive(false);
        panel.SetActive(false);
        buttonPressed = false;
        Debug.Log(buttonPressed);

    }

    void Update()
    {
        if (buttonPressed == true)
        {
            Debug.Log("entered loop");
            float elapsedTime = Time.time - startTime;
            //timee -= Time.deltaTime;
            Debug.Log($"time elapsed is {elapsedTime}");

            if (elapsedTime > 5.3)
            {
                Debug.Log("Opening panel");
                panel.SetActive(true);
                bubble.SetActive(true);
                nextButton.SetActive(true);
                repeatButton.SetActive(true);
                missionComplete = true;
                
            }
        }
    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        buttonPressed = true;
        //cylinder.SetActive(true);
        move.Play("moveSnail");
        Debug.Log("button pressed");
        //Invoke("OpenPanel", delay);

        startTime = Time.time;
        Debug.Log($"start time is {startTime}");
        // Debug.Log("timer started");
        // //Debug.Log($"time is {timee}");
        
        // while (buttonPressed == true)
        // {
        //     float elapsedTime = Time.time - startTime;
        //     //timee -= Time.deltaTime;
        //     Debug.Log($"time elapsed is {elapsedTime}");

        //     if (elapsedTime < 0)
        //     {
        //         Debug.Log("Opening panel");
        //         panel.SetActive(true);
        //         missionComplete = true;
        //         break;
        //     }
        // }

       
        //rb.MovePosition(transform.position + Vector3.right * 3000000 * Time.deltaTime);
       // Debug.Log("trying to move!");
        
    }



    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //cylinder.SetActive(false);
        move.Play("noMove");
        Debug.Log("button released");
        buttonPressed = false;
        Debug.Log("closing panel");

        // if (missionComplete == false)
        // {
        //     panel.SetActive(false);
        //     bubble.SetActive(false);

        // }
        // else
        // {
        //     panel.SetActive(true);  
        //     bubble.SetActive(true);  
        // }


    }

    public void restartMission()
    {
        missionComplete = false;
    }
}

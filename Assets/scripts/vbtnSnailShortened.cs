// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using Vuforia;

// public class VBTN_snail : MonoBehaviour
// {

//     public Animator move;
//     public VirtualButtonBehaviour Vb;
//     public GameObject panel;
//     public volatile bool buttonPressed = false;
//     public bool missionComplete = false;
//     public float startTime;

//     void Start()
//     {
//         //initialization code
//         Vb.RegisterOnButtonPressed(OnButtonPressed);
//         Vb.RegisterOnButtonReleased(OnButtonReleased);
//         panel.SetActive(false);
//         buttonPressed = false;
//     }

//     void Update()
//     {
//         if (buttonPressed == true) //checks if virtual button has been pressed
//         {
//             Debug.Log("entered loop");
//             float elapsedTime = Time.time - startTime;

//             if (elapsedTime > 6)
//             {
//                 panel.SetActive(true); //opens success panel after snail reaches plant
//                 missionComplete = true;
                
//             }
//         }
//     }


//     public void OnButtonPressed(VirtualButtonBehaviour vb)
//     {
//         buttonPressed = true; //
//         move.Play("moveSnail"); // start animation of moving snail
//         Debug.Log("button pressed");
//         startTime = Time.time;
        
//     }


//     public void OnButtonReleased(VirtualButtonBehaviour vb)
//     {
//         buttonPressed = false;
//         move.Play("noMove"); //stops the snail movement
//         Debug.Log("button released");
        
//         if (missionComplete == false) //checks if snail has reached the plant
//         {
//             panel.SetActive(false);
//         }
//         else
//         {
//             panel.SetActive(true); //keeps the success panel open once task is complete
//         }

//     }
// }

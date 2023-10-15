using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class snail_movement : MonoBehaviour
{
    // public Animator snailMove;
    //public GameObject cylinder;
    public Rigidbody rb;
    public VirtualButtonBehaviour Vb;

    //Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);
        //cylinder.SetActive(false);

    }

    void Update() {

        // float x = 
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //cylinder.SetActive(true);
        Debug.Log("button pressed");
        rb.MovePosition(transform.position + Vector3.right * 3000000 * Time.deltaTime);
        Debug.Log("trying to move!");
        
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //cylinder.SetActive(false);
        Debug.Log("button released");

    }
}

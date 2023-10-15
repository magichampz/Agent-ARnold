using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class modelAppear : MonoBehaviour
{
    public GameObject model;
    public VirtualButtonBehaviour Vb;
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(onButtonPressed);
        model.SetActive(false);
    }

    public void onButtonPressed(VirtualButtonBehaviour vb)
    {
        model.SetActive(true);
    }
}

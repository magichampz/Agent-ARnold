using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class ansVBTN : MonoBehaviour
{
    public GameObject cube;
    public VirtualButtonBehaviour Vb;
    public Material myMaterial;

    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);
        myMaterial.color = Color.white;
    }

    // Update is called once per frame
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        myMaterial.color = Color.green;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        myMaterial.color = Color.white;
    }
}

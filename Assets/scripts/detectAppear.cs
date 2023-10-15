using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectAppear : MonoBehaviour
{

    public GameObject success;
    public GameObject next;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (success.activeSelf == true)
        {
            next.SetActive(true);
        }
    }
}

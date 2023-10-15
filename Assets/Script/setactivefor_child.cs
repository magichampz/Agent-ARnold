using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setactivefor_child : MonoBehaviour
{
    public string childname;
    private int num = 0;
    public bool show;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
      
    {
        if (Input.GetMouseButtonDown(0)&& num >0)
        {
            transform.Find(childname).gameObject.SetActive(show);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            num = num + 1;
        }
    }
}

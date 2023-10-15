using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showObject : MonoBehaviour
{
    public GameObject toShow1;
    public GameObject toShow2;
    public GameObject m1;
    public GameObject m2;
    public GameObject m3;

    void Start()
    {
        m1.SetActive(false);
        m2.SetActive(false);
        m3.SetActive(false);
        toShow1.SetActive(false);
        toShow2.SetActive(false);
    }
    
    void Update()
    {
        show();
    }

    public void show()
    {
        if (m1.activeSelf && m2.activeSelf && m3.activeSelf)
        {
            Debug.Log("lalala");
            toShow1.SetActive(true);
            toShow2.SetActive(true);
        }
    }
}

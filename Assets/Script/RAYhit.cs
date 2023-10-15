using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class RAYhit : MonoBehaviour
{
    public GameObject arcamera;
    public GameObject correct;
    public GameObject incorecct;
    public void hit_object()
    {
        RaycastHit rayhit;
        if (Physics.Raycast(arcamera.transform.position,arcamera.transform.forward, out rayhit))
        {
            if (rayhit.transform.gameObject.tag == "anyswer")
            {
                correct.SetActive(true);
            }

            else if (rayhit.transform.gameObject.tag=="wrong")
            {
                incorecct.SetActive(true);
            }
        }
    }
}

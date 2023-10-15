using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class des : MonoBehaviour
{
    public string tagname;
    public void destroy_child()
    {
        Destroy(GameObject.FindWithTag(tagname));
    }
}

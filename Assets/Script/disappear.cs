using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappear : MonoBehaviour
{
    public GameObject parent;
    public string child;
    public bool a;
    public void disappear_object()
    {
        parent = transform.Find(child).gameObject;
        parent.SetActive(a);
    }
}
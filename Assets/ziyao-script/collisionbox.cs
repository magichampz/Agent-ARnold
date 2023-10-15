using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionbox : MonoBehaviour
{
    public GameObject menu;
    public string correct_tag;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == correct_tag)
        {
            menu.SetActive(true);
        }
        Debug.Log("collision");
    }
}
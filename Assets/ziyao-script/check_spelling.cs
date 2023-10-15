using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check_spelling : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    
   
    public GameObject correct_object;
    public GameObject incorrect_object;
    public string tagName;
    //public GameObject incorrect_object;
    public string correct;
    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == tagName && other.gameObject.layer == 7)
        {
            correct_object.SetActive(true);
            incorrect_object.SetActive(false);
            Debug.Log("collision");
        }
        else if (other.tag != tagName && other.gameObject.layer == 7)
        {
            incorrect_object.SetActive(true);
            correct_object.SetActive(false);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.tag != tagName && other.gameObject.layer == 7)
        {
            //Panel1.SetActive(false);
        }



    }
}

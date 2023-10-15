using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Panel;
    public GameObject Panel1;
    public string correct;
    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == correct && other.gameObject.layer == 7)
        {
            Panel.SetActive(true);
         
            Debug.Log("collision");
        }
        else if (other.tag != correct && other.gameObject.layer == 7)
        {
            Panel1.SetActive(true);
            Debug.Log(other.tag);

        }
    }
    public void OnTriggerExit(Collider other)
     {
         if(other.tag != correct && other.gameObject.layer == 7)
         {  
             Panel1.SetActive(false);
         }


   
}

   
  }
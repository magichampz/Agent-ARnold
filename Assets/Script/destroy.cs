using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
   
{
    public string tag1;
    public string tag2;
    public string tag3;
   public void destroybytag()
    {
        Destroy(GameObject.FindWithTag(tag1));
        Destroy(GameObject.FindWithTag(tag2));
        Destroy(GameObject.FindWithTag(tag3));
    }
    

}

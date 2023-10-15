using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snailCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "snail")
        {
            Debug.Log("Collision1!!!");
            print("Collided");
        }

        Debug.Log("Collision1!!!");
        print("Collided");

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "snail")
        {
            Debug.Log("Collision1!!!");
            print("Collided");
        }
        
        Debug.Log("Collision1!!!");
        print("Collided");

    }
    
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "snail")
        {
            Debug.Log("Collision1!!!");
            print("Collided");
        }
        
        Debug.Log("Collision1!!!");
        print("Collided");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class regiondetect : MonoBehaviour
{
    public BoxCollider box1;
    public BoxCollider box2;
    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreCollision(box1, box2, true);
    }

  
}

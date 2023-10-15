using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delaytime : MonoBehaviour
{
    // Start is called before the first frame update
    public float wait_time;
    IEnumerator delay_time()
    {
    
        yield return new WaitForSeconds(wait_time);
        
    }
}



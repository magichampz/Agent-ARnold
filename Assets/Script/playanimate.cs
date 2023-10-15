using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playanimation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject otherobject;
    public string myanimation;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void play_myanimation()
    {
        otherobject.GetComponent<Animator>().Play(myanimation);
    }
}

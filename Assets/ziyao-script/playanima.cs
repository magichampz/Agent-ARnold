using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playanima : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animate;
    public GameObject otherobject;
    public string animation_name;
    // Update is called once per frame
    public void play_myanimation()
    {
        animate=otherobject.GetComponent<Animator>();
        animate.SetBool(animation_name,true);
    }
}

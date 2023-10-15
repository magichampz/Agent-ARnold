using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delayAppear : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float delay;
    
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void Hide()
    {
        Invoke("Show",delay);

    }
    public void Show()
    {
        gameObject.SetActive(true);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

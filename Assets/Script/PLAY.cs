using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PLAY : MonoBehaviour
{
    // Start is called before the first frame update
    public RectTransform Button;
    public string on_video;
    public string off_video;
    void Start()
    {
        Button.GetComponent<Animator>().Play(off_video);
    }
    public void Onpointerenter(PointerEventData eventdata)
    {
        Button.GetComponent<Animator>().Play(on_video);
    }
    public void Onpointerexit(PointerEventData eventdata)
    {
        Button.GetComponent<Animator>().Play(off_video);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

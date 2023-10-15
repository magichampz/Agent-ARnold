using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetappear : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject game;
    public string childname;
    public bool state;
    public void setactiveo()
    {
        game.transform.Find(childname).gameObject.SetActive(state);
    }

}

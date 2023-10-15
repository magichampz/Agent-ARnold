using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextARbutton : MonoBehaviour
{
    public string nextscene;

    void OnMouseDown()
    {
        SceneManager.LoadScene(nextscene);
    }


}

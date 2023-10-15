using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detectiveExplosion : MonoBehaviour
{
public string nextscene;
public string firstlevel;
    
    public void nextScene()
    {
        SceneManager.LoadScene(nextscene);
    }

    public void Quitto()
    {
        SceneManager.LoadScene(firstlevel);
    }

}

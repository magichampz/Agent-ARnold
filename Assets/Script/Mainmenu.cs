using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Mainmenu : MonoBehaviour
{
    public string firstlevel;

    public void StartGame()
    {
        SceneManager.LoadScene(firstlevel);
    }
    public void OpenOption()
    {

    }
    public void Quitgame()
    {
        Application.Quit();
        Debug.Log("quitting");
    }
}
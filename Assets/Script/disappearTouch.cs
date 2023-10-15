using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class disappearTouch : MonoBehaviour
{

    public string explosion;

    void OnMouseDown()
    {
        gameObject.SetActive(false);
       //Destroy(gameObject); 
       Debug.Log("clear explosion");
       //SceneManager.UnloadSceneAsync();
       SceneManager.LoadScene(explosion);
    }


}

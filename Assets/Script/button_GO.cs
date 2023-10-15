using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class button_GO : MonoBehaviour
{
    public float raylength;
    public LayerMask layerMask;
    public GameObject correcto;
    public GameObject incorrecto;
   
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)&& !EventSystem.current.IsPointerOverGameObject())
        {

            RaycastHit Hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out Hit, raylength, layerMask))
            {


                Debug.Log(Hit.collider.name);
                if (Hit.collider.tag == "wrong")
                {

                    Debug.Log("incorret");
                    incorrecto.SetActive(true);
                    correcto.SetActive(false);
                }
                else if (Hit.collider.tag == "anyswer")
                {
                    Debug.Log("correct");
                    correcto.SetActive(true);
                    incorrecto.SetActive(false);

                }
  
            }
            
        }
    }
}
 
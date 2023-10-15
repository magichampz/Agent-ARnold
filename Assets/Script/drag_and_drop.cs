using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag_and_drop : MonoBehaviour
{

    Vector3 dist;
    float position_X;
    float position_Y;

    void OnMouseDown()
    {
        dist = Camera.main.WorldToScreenPoint(transform.position);
        position_X = Input.mousePosition.x - dist.x;
        position_Y = Input.mousePosition.y - dist.y;

    }

    void OnMouseDrag()
    {
        Vector3 curPos =
         new Vector3(Input.mousePosition.x - position_X,
                     Input.mousePosition.y - position_Y, dist.z);

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
        transform.position = worldPos;
    }
}

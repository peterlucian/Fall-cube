using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderPiece : MonoBehaviour
{
    public float speed = 5F;
    void Update()
    {
        //transform.Rotate(0, (Input.GetAxis("Horizontal") * speed ), 0);

        if(Input.touchCount == 1)
        {
            Touch screenTouch = Input.GetTouch(0);
            if (screenTouch.phase == TouchPhase.Moved)
                transform.Rotate(0f, screenTouch.deltaPosition.x * 60F * Time.deltaTime, 0f);
        }

    }
 }

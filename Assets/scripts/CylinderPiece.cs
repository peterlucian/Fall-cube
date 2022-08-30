using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderPiece : MonoBehaviour
{
    public float speed = 5F;
    void Update()
    {
        transform.Rotate(0, (Input.GetAxis("Horizontal") * speed ), 0);
    }
 }

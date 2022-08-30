using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public float smoothing = 7F;
    public Vector3 LastPosition { 
        get { return lastPosition; } 
        set 
        { 
            lastPosition = value;

        } 
    }

    private Vector3 lastPosition;
    public Vector3 CurrentPosition 
    { 
        get { return currentPosition;  }
        set 
        { 
            currentPosition = value;
            SetTransformPosition();
            //StopCoroutine("MoveToPosition");
            //StartCoroutine("MoveToPosition", currentPosition);
        }
    }

    private Vector3 currentPosition;

    public Rigidbody m_Rigidbody;

    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }
    protected void Awake()
    {
        CurrentPosition = transform.localPosition;

    }

    public void SetTransformPosition()
    {
        transform.localPosition = CurrentPosition;
    }

    /*
    IEnumerator MoveToPosition(Vector3 target)
    {
        while (Vector3.Distance(transform.localPosition, target) > 0.05F)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, target, smoothing * Time.deltaTime);
            yield return null;
        }
    }
    
    private float m_Speed = 10F;
    public IEnumerator MoveToPosition(Vector3 target)
    {
        float t = 0;
        while (t <= 1)
        {
            t += Time.fixedDeltaTime / m_Speed;
            Vector3 start = transform.localPosition; //assign inside the while loop for updating your moving object's local position, since it moves
            m_Rigidbody.MovePosition(start + target * Time.deltaTime);
            yield return null;
        }
    }*/


}

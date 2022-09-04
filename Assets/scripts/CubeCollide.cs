using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CubeCollide : MonoBehaviour
{
    public float bounce = 0.05F;
    public UnityEvent myEvent;
    public bool colliding = false;
    public Rigidbody m_rb;
    private bool moveDown;
    private void Start()
    {
        m_rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Piece")
        {
            //m_rb.AddForce(new Vector3(0, transform.position.y * bounce, 0), ForceMode.Impulse);
            //m_rb.velocity = new Vector3(0, 5F, 0);
            colliding = true;
            moveDown = false;
        }

        if (other.gameObject.tag == "piecescore")
        {
            Debug.Log("Colliding" + transform.position.y);
            myEvent.Invoke();    
            moveDown = false;
            
        }

        if (other.gameObject.tag == "piecestop")
        {
            //Debug.Log("Colliding" + transform.position.y);
            //m_rb.AddForce(new Vector3(0, - transform.position.y * bounce, 0), ForceMode.Impulse);
            moveDown = true;
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        colliding = false;
    }
    

    private void FixedUpdate()
    {
        if (moveDown)
            m_rb.velocity = Vector3.down;
        else
            m_rb.velocity = Vector3.up;
        

    }
    private void Update()
    {

        //if (transform.position.y > 4.5F)
           //m_rb.velocity = Vector3.zero;

        
        if(transform.position.y < 2.685F)
        {
            m_rb.useGravity = false;
            m_rb.velocity = Vector3.zero;

        }
        
     
    }

   
}

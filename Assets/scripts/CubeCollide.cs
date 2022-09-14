using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CubeCollide : MonoBehaviour
{
    public float bounce = 0.25F;
    public UnityEvent myEvent;
    public bool colliding = false;
    public Rigidbody m_rb;
    public UnityEvent addScore;

    private void Start()
    {
        m_rb = GetComponent<Rigidbody>();      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Piece")
        {
            FindObjectOfType<AudioManager>().Play("ballSound");
            Debug.Log("Colliding with piece" + other.gameObject.transform.parent.name);
            m_rb.velocity = Vector3.zero;
            m_rb.AddForce(new Vector3(0, bounce, 0), ForceMode.Impulse);
        }

        if (other.gameObject.tag == "piecescore")
        {
            addScore.Invoke();
            FindObjectOfType<AudioManager>().Play("transiction");
            Debug.Log("Colliding with pieceScore" + other.gameObject.transform.parent.name);
            colliding = true;
            m_rb.velocity = Vector3.zero;        
            myEvent.Invoke();                  
        }

        if (other.gameObject.tag == "piecestop")
        {
            m_rb.velocity = Vector3.zero;
            m_rb.AddForce(new Vector3(0, - bounce, 0), ForceMode.Impulse);
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "piecescore")
        {
            colliding = false;

        }  
    }
    private void Update()
    {
       
        if(transform.position.y < 1.158F)
        {
            m_rb.useGravity = false;
            m_rb.velocity = Vector3.zero;

        }    

    }

   
}

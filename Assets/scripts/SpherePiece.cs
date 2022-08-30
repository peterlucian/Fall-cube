using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class SpherePiece : MonoBehaviour
{
   
    /*
    private Transform cylinder;
    public Queue<Piece> pieces = new Queue<Piece>();

    public GameObject pieceEntirePrefab;
    public GameObject pieceHalfPrefab;
    public GameObject pieceOneQuarterPrefab;

    private GameObject[] piecesRand;

    private void Awake()
    {
        cylinder = GameObject.Find("Cylinder").transform;
        piecesRand = new GameObject[3] { pieceEntirePrefab, pieceHalfPrefab, pieceOneQuarterPrefab };
    }


    private void Start()
    {

        pieces.Enqueue(Instantiate(pieceEntirePrefab, cylinder).GetComponent<Piece>());
        pieces.Enqueue(Instantiate(pieceHalfPrefab, cylinder).GetComponent<Piece>());
        pieces.Enqueue(Instantiate(pieceOneQuarterPrefab, cylinder).GetComponent<Piece>());

    }

    private void Update()
    {
        bool first = true;
        Piece current = null;
        Piece prev = null;

        if (transform.position.y > 3.5F)
            transform.position = new Vector3(0, 3.5F, -0.8F);

        if (transform.position.y < 2.44F && !isCurrentlyColliding) {
            transform.position = new Vector3(0, 3.9F, -0.8F);

            bool notfirst = false;

            foreach (Piece next in pieces)
            {
                

                prev = current;
                current = next;

                if (!first)
                {
                    current.SetLastPosition(current.currentPosition);
                    if (prev.lastPosition == new Vector3(0,0,0) && !notfirst)
                    {
                        prev.SetLastPosition(new Vector3(0, 0.5F, 0));
                        notfirst = true;

                    }
            
                    current.SetCurrentPosition(prev.lastPosition);
                    
                }

                

                first = false;
            }
            
            Destroy(pieces.Peek().gameObject);
            pieces.Dequeue();

            GameObject pieceToInstantiate = Instantiate(piecesRand[Random.Range(0, 3)]);

            pieceToInstantiate.transform.parent = cylinder;
            pieceToInstantiate.transform.localPosition = new Vector3(0, -0.5F, 0);
            pieceToInstantiate.transform.rotation = Quaternion.Euler(-90, 0, Random.Range(0, 360));
            pieceToInstantiate.transform.localScale = new Vector3(100, 100, 50);

            pieces.Enqueue(pieceToInstantiate.GetComponent<Piece>());
        }

    }

    bool isCurrentlyColliding;
   
    void OnCollisionEnter(Collision collision)
    { 
        if (collision.gameObject.tag == "Piece")
        {
            //isCurrentlyColliding = true;
            
        } 
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Piece")
        {
            //isCurrentlyColliding = false;
            

        }
    } */
}

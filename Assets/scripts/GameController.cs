using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Transform cylinder;
    private Transform cube;

    public Queue<Piece> pieces = new Queue<Piece>();

    public GameObject pieceEntirePrefab;
    public GameObject pieceHalfPrefab;
    public GameObject pieceOneQuarterPrefab;
    public GameObject pieceOneQuarterPrefabdup;

    private GameObject[] piecesRand;

    private void Awake()
    {
        cylinder = GameObject.Find("Cylinder").transform;
        cube = GameObject.Find("Cube").transform;
        piecesRand = new GameObject[3] { pieceEntirePrefab, pieceHalfPrefab, pieceOneQuarterPrefab };
    }

    private void Start()
    {

        pieces.Enqueue(Instantiate(pieceEntirePrefab, cylinder).GetComponent<Piece>());
        pieces.Enqueue(Instantiate(pieceHalfPrefab, cylinder).GetComponent<Piece>());
        pieces.Enqueue(Instantiate(pieceOneQuarterPrefab, cylinder).GetComponent<Piece>());
        pieces.Enqueue(Instantiate(pieceOneQuarterPrefabdup, cylinder).GetComponent<Piece>());

    }

    bool isCurrentlyColliding;
    public void ClickMe()
    { 
        
        bool first = true;
        Piece current = null;
        Piece prev = null;
        
        if (cube.transform.position.y < 2.685F && !cube.GetComponent<CubeCollide>().colliding)
        {
            Debug.Log("im here");
            bool notfirst = false;

            foreach (Piece next in pieces)
            {


                prev = current;
                current = next;

                if (!first)
                {
                    current.LastPosition = current.CurrentPosition;
                    if (prev.LastPosition == new Vector3(0, 0, 0) && !notfirst)
                    {
                        prev.LastPosition = new Vector3(0, 0.5F, 0);
                        prev.CurrentPosition = new Vector3(0, 1, 0);
                        notfirst = true;

                    }

                    current.CurrentPosition = prev.LastPosition;
                    current.m_Rigidbody.velocity = new Vector3(0, 5.5F, 0);

                    Debug.Log("Local Position" + current.transform.localPosition + "Current positon" + current.CurrentPosition);

                }



                first = false;
            }
           

            Destroy(pieces.Peek().gameObject);
            pieces.Dequeue();
            
            GameObject pieceToInstantiate = Instantiate(piecesRand[Random.Range(0, 3)]);

            pieceToInstantiate.transform.parent = cylinder;
            pieceToInstantiate.transform.localPosition = new Vector3(0, -1F, 0);
            pieceToInstantiate.transform.rotation = Quaternion.Euler(-90, 0, Random.Range(0, 360));
            pieceToInstantiate.transform.localScale = new Vector3(100, 100, 50);
           
            pieceToInstantiate.GetComponent<Piece>().CurrentPosition = new Vector3(0, -1F, 0);
            pieces.Enqueue(pieceToInstantiate.GetComponent<Piece>());
            
        }
        
      
    }

    private void Update()
    {

           
        foreach (Piece next in pieces)
        {
            if (Vector3.Distance(next.transform.localPosition, next.CurrentPosition) < 0.03F)
            {
                //Debug.Log("inside the stop piece");
                next.m_Rigidbody.velocity = Vector3.zero;

            }

        }
    }
}

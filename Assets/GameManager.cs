using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    BoardManager board;
    private LayerMask OmoSelectionLayer;
    
    void Start()
    {
        board = gameObject.GetComponent<BoardManager>();
        
        board.CreateBoard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void selection()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit rayHit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out rayHit, 25, OmoSelectionLayer))
            {
                rayHit.collider.GetComponent<Pieces>().
            }
        }
    }
}

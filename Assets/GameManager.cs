using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    BoardManager board;
    
    void Start()
    {
        board = gameObject.GetComponent<BoardManager>();
        
        board.CreateBoard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

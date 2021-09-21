using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    [SerializeField] GameObject boardTiles =null;
    [SerializeField] GameObject omoPieces = null;
    [SerializeField] Material boardwhite=null;
    [SerializeField] Material boardBlack=null;
    [SerializeField]  private int  rowAndCol = 8;
    [HideInInspector] public static string[] tilesName = new string[] { "a", "b", "c", "d", "e", "f", "g", "h" };

    GameObject[,] squares;
    GameObject[,] omos;
    public void CreateBoard()
    {
        //Creating a 2D array and setting the rows and collums to the value set in rowAndCol variable
         squares = new GameObject[rowAndCol, rowAndCol];
        omos = new GameObject[rowAndCol, rowAndCol];
        for (int i=0; i< rowAndCol; i++)
        {
            for (int j=0; j< rowAndCol; j++)
            {
                squares[i, j] = Instantiate(boardTiles, new Vector3(i, 0, j), Quaternion.identity);
                
                // Black blocks will always be at all even or all odd positions [5,7] || [2,6] 
                if ((i % 2 != 0 && j % 2 !=0) || (i % 2 == 0 && j % 2 == 0))
                {
                    squares[i, j].GetComponent<Renderer>().material = boardBlack;
                }
                else
                {
                    squares[i, j].GetComponent<Renderer>().material = boardwhite;
                }
                //Setting all created tiles as children of the gameObject to clean up the hierarchy window
                squares[i, j].transform.SetParent(this.transform);
                // Naming all the tiles for future reference
                squares[i, j].name = tilesName[i] + (j + 1);

            }
                
        }
        for (int i = 0; i < rowAndCol; i++)
        {
            for (int j = 0; j < rowAndCol; j++)
            {
                omos[i, j] = Instantiate(omoPieces, new Vector3(i, 0.2f, j), Quaternion.identity);
                //[i, j].GetComponent<Renderer>().material = omoColor1; 

                omos[i, j].transform.SetParent(this.transform);
                // Naming all the omos for future reference
                omos[i, j].name = "omo" + tilesName[i] + (j + 1);

            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pawn : basePiece
{
    
    // Start is called before the first frame update
    void Start()
    {
        buttonGrids = FindObjectOfType<buttonGridController>();
    }

    // Update is called once per frame
    void Update()
    {
        buttonGrids = FindObjectOfType<buttonGridController>();
    }

    public override List<boardSquares> CheckMoveWhite(boardSquares[,] squares)
    {
        List<boardSquares> squaresToReturn = new List<boardSquares>();
        int newY = positionY + 1;
        int newXL = positionX - 1;
        int newXR = positionX + 1;
        if (newY < 8)
        {
            if (squares[newY, positionX].GetPiece() == null)
            {
                squaresToReturn.Add(squares[newY, positionX]);
                buttonGrids.SetBool(positionX, newY);
                if (moved == false)
                {
                    int newY2 = positionY + 2;
                    if (newY2 < 8)
                    {
                        if (squares[newY2, positionX].GetPiece() == null)
                        {
                            squaresToReturn.Add(squares[newY2, positionX]);
                            buttonGrids.SetBool(positionX, newY2);
                        }
                    }
                }
            }
            if (newXL >= 0)
            {
                if (squares[newY, newXL].GetPiece() != null)
                {
                    if (squares[newY, newXL].GetPiece().GetColour() == true)
                    {
                        squaresToReturn.Add(squares[newY, newXL]);
                        buttonGrids.SetBool(newXL, newY);
                    }
                }
            }
            if (newXR < 8)
            {
                if (squares[newY, newXR].GetPiece() != null)
                {
                    if (squares[newY, newXR].GetPiece().GetColour() == true)
                    {
                        squaresToReturn.Add(squares[newY, newXR]);
                        buttonGrids.SetBool(newXR, newY);
                    }
                }
            }
        }
        return squaresToReturn;
    }

    public override List<boardSquares> CheckMoveBlack(boardSquares[,] squares)
    {
        List<boardSquares> squaresToReturn = new List<boardSquares>();
        int newY = positionY - 1;
        int newXL = positionX - 1;
        int newXR = positionX + 1;
        if (newY >= 0)
        {
            if (squares[newY, positionX].GetPiece() == null)
            {
                squaresToReturn.Add(squares[newY, positionX]);
                buttonGrids.SetBool(positionX, newY);
                if (moved == false)
                {
                    int newY2 = positionY - 2;
                    if (newY2 >= 0)
                    {
                        if (squares[newY2, positionX].GetPiece() == null)
                        {
                            squaresToReturn.Add(squares[newY2, positionX]);
                            buttonGrids.SetBool(positionX, newY2);
                        }
                    }
                }
            }
            if (newXL >= 0)
            {
                if (squares[newY, newXL].GetPiece() != null)
                {
                    if (squares[newY, newXL].GetPiece().GetColour() == false)
                    {
                        squaresToReturn.Add(squares[newY, newXL]);
                        buttonGrids.SetBool(newXL, newY);
                    }
                }
            }
            if (newXR < 8)
            {
                if (squares[newY, newXR].GetPiece() != null)
                {
                    if (squares[newY, newXR].GetPiece().GetColour() == false)
                    {
                        squaresToReturn.Add(squares[newY, newXR]);
                        buttonGrids.SetBool(newXR, newY);
                    }
                }
            }
        }
        return squaresToReturn;
    }
}

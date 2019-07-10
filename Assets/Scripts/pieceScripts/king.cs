using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class king : basePiece
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
        int newY = positionY;
        int newX = positionX + 1;
        if (newX < 8)
        {
            if (squares[positionY, newX].GetPiece() == null)
            {
                squaresToReturn.Add(squares[positionY, newX]);
                buttonGrids.SetBool(newX, positionY);
            }
            else
            {
                if (squares[positionY, newX].GetPiece().GetColour() == true)
                {
                    squaresToReturn.Add(squares[positionY, newX]);
                    buttonGrids.SetBool(newX, positionY);
                }
            }
        }
        newX = positionX - 1;
        if (newX >= 0)
        {
            if (squares[positionY, newX].GetPiece() == null)
            {
                squaresToReturn.Add(squares[positionY, newX]);
                buttonGrids.SetBool(newX, positionY);
            }
            else
            {
                if (squares[positionY, newX].GetPiece().GetColour() == true)
                {
                    squaresToReturn.Add(squares[positionY, newX]);
                    buttonGrids.SetBool(newX, positionY);
                }
            }
        }
        newY = positionY + 1;
        if (newY < 8)
        {
            if (squares[newY, positionX].GetPiece() == null)
            {
                squaresToReturn.Add(squares[newY, positionX]);
                buttonGrids.SetBool(positionX, newY);
            }
            else
            {
                if (squares[newY, positionX].GetPiece().GetColour() == true)
                {
                    squaresToReturn.Add(squares[newY, positionX]);
                    buttonGrids.SetBool(positionX, newY);
                }
            }
        }
        newY = positionY - 1;
        if (newY >= 0)
        {
            if (squares[newY, positionX].GetPiece() == null)
            {
                squaresToReturn.Add(squares[newY, positionX]);
                buttonGrids.SetBool(positionX, newY);
            }
            else
            {
                if (squares[newY, positionX].GetPiece().GetColour() == true)
                {
                    squaresToReturn.Add(squares[newY, positionX]);
                    buttonGrids.SetBool(positionX, newY);
                }
            }
        }
        newX = positionX + 1;
        newY = positionY + 1;
        if (newX < 8 && newY < 8)
        {
            if (squares[newY, newX].GetPiece() == null)
            {
                squaresToReturn.Add(squares[newY, newX]);
                buttonGrids.SetBool(newX, newY);
            }
            else
            {
                if (squares[newY, newX].GetPiece().GetColour() == true)
                {
                    squaresToReturn.Add(squares[newY, newX]);
                    buttonGrids.SetBool(newX, newY);
                }
            }
        }
        newY = positionY - 1;
        if (newX < 8 && newY >= 0)
        {
            if (squares[newY, newX].GetPiece() == null)
            {
                squaresToReturn.Add(squares[newY, newX]);
                buttonGrids.SetBool(newX, newY);
            }
            else
            {
                if (squares[newY, newX].GetPiece().GetColour() == true)
                {
                    squaresToReturn.Add(squares[newY, newX]);
                    buttonGrids.SetBool(newX, newY);
                }
            }
        }
        newX = positionX - 1;
        if (newX >= 0 && newY >= 0)
        {
            if (squares[newY, newX].GetPiece() == null)
            {
                squaresToReturn.Add(squares[newY, newX]);
                buttonGrids.SetBool(newX, newY);
            }
            else
            {
                if (squares[newY, newX].GetPiece().GetColour() == true)
                {
                    squaresToReturn.Add(squares[newY, newX]);
                    buttonGrids.SetBool(newX, newY);
                }
            }
        }
        newY = positionY + 1;
        if (newX >= 0 && newY < 8)
        {
            if (squares[newY, newX].GetPiece() == null)
            {
                squaresToReturn.Add(squares[newY, newX]);
                buttonGrids.SetBool(newX, newY);
            }
            else
            {
                if (squares[newY, newX].GetPiece().GetColour() == true)
                {
                    squaresToReturn.Add(squares[newY, newX]);
                    buttonGrids.SetBool(newX, newY);
                }
            }
        }
        return squaresToReturn;
    }

    public override List<boardSquares> CheckMoveBlack(boardSquares[,] squares)
    {
        List<boardSquares> squaresToReturn = new List<boardSquares>();
        int newY = positionY;
        int newX = positionX + 1;
        if (newX < 8)
        {
            if (squares[positionY, newX].GetPiece() == null)
            {
                squaresToReturn.Add(squares[positionY, newX]);
                buttonGrids.SetBool(newX, positionY);
            }
            else
            {
                if (squares[positionY, newX].GetPiece().GetColour() == false)
                {
                    squaresToReturn.Add(squares[positionY, newX]);
                    buttonGrids.SetBool(newX, positionY);
                }
            }
        }
        newX = positionX - 1;
        if (newX >= 0)
        {
            if (squares[positionY, newX].GetPiece() == null)
            {
                squaresToReturn.Add(squares[positionY, newX]);
                buttonGrids.SetBool(newX, positionY);
            }
            else
            {
                if (squares[positionY, newX].GetPiece().GetColour() == false)
                {
                    squaresToReturn.Add(squares[positionY, newX]);
                    buttonGrids.SetBool(newX, positionY);
                }
            }
        }
        newY = positionY + 1;
        if (newY < 8)
        {
            if (squares[newY, positionX].GetPiece() == null)
            {
                squaresToReturn.Add(squares[newY, positionX]);
                buttonGrids.SetBool(positionX, newY);
            }
            else
            {
                if (squares[newY, positionX].GetPiece().GetColour() == false)
                {
                    squaresToReturn.Add(squares[newY, positionX]);
                    buttonGrids.SetBool(positionX, newY);
                }
            }
        }
        newY = positionY - 1;
        if (newY >= 0)
        {
            if (squares[newY, positionX].GetPiece() == null)
            {
                squaresToReturn.Add(squares[newY, positionX]);
                buttonGrids.SetBool(positionX, newY);
            }
            else
            {
                if (squares[newY, positionX].GetPiece().GetColour() == false)
                {
                    squaresToReturn.Add(squares[newY, positionX]);
                    buttonGrids.SetBool(positionX, newY);
                }
            }
        }
        newX = positionX + 1;
        newY = positionY + 1;
        if (newX < 8 && newY < 8)
        {
            if (squares[newY, newX].GetPiece() == null)
            {
                squaresToReturn.Add(squares[newY, newX]);
                buttonGrids.SetBool(newX, newY);
            }
            else
            {
                if (squares[newY, newX].GetPiece().GetColour() == false)
                {
                    squaresToReturn.Add(squares[newY, newX]);
                    buttonGrids.SetBool(newX, newY);
                }
            }
        }
        newY = positionY - 1;
        if (newX < 8 && newY >= 0)
        {
            if (squares[newY, newX].GetPiece() == null)
            {
                squaresToReturn.Add(squares[newY, newX]);
                buttonGrids.SetBool(newX, newY);
            }
            else
            {
                if (squares[newY, newX].GetPiece().GetColour() == false)
                {
                    squaresToReturn.Add(squares[newY, newX]);
                    buttonGrids.SetBool(newX, newY);
                }
            }
        }
        newX = positionX - 1;
        if (newX >= 0 && newY >= 0)
        {
            if (squares[newY, newX].GetPiece() == null)
            {
                squaresToReturn.Add(squares[newY, newX]);
                buttonGrids.SetBool(newX, newY);
            }
            else
            {
                if (squares[newY, newX].GetPiece().GetColour() == false)
                {
                    squaresToReturn.Add(squares[newY, newX]);
                    buttonGrids.SetBool(newX, newY);
                }
            }
        }
        newY = positionY + 1;
        if (newX >= 0 && newY < 8)
        {
            if (squares[newY, newX].GetPiece() == null)
            {
                squaresToReturn.Add(squares[newY, newX]);
                buttonGrids.SetBool(newX, newY);
            }
            else
            {
                if (squares[newY, newX].GetPiece().GetColour() == false)
                {
                    squaresToReturn.Add(squares[newY, newX]);
                    buttonGrids.SetBool(newX, newY);
                }
            }
        }
        return squaresToReturn;
    }
}

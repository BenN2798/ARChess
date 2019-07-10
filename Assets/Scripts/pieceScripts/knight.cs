using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knight : basePiece
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
        int newY = positionY + 2;
        int newX = positionX + 1;
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
        newX = positionX - 1;
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
        newX = positionX + 1;
        newY = positionY - 2;
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
        newX = positionX + 2;
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
        newX = positionX - 2;
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
        newY = positionY - 1;
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
        return squaresToReturn;
    }

    public override List<boardSquares> CheckMoveBlack(boardSquares[,] squares)
    {
        List<boardSquares> squaresToReturn = new List<boardSquares>();
        int newY = positionY + 2;
        int newX = positionX + 1;
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
        newX = positionX - 1;
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
        newX = positionX + 1;
        newY = positionY - 2;
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
        newX = positionX + 2;
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
        newX = positionX - 2;
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
        newY = positionY - 1;
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
        return squaresToReturn;
    }
}

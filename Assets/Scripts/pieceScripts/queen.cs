using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class queen : basePiece
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

    public void ConvertFromPawn(int _x, int _y, int _id, bool _dark)
    {
        positionX = _x;
        positionY = _x;
        id = _id;
        dark = _dark;
    }

    public override List<boardSquares> CheckMoveWhite(boardSquares[,] squares)
    {
        List<boardSquares> squaresToReturn = new List<boardSquares>();
        int newY = positionY;
        int newX = positionX + 1;
        bool continueCheck = true;
        while (continueCheck)
        {
            if (newX < 8)
            {
                if (squares[positionY, newX].GetPiece() == null)
                {
                    squaresToReturn.Add(squares[positionY, newX]);
                    buttonGrids.SetBool(newX, positionY);
                    newX = newX + 1;
                }
                else
                {
                    continueCheck = false;
                    if (squares[positionY, newX].GetPiece().GetColour() == true)
                    {
                        squaresToReturn.Add(squares[positionY, newX]);
                        buttonGrids.SetBool(newX, positionY);
                    }
                }
            }
            else
            {
                continueCheck = false;
            }
        }
        newX = positionX - 1;
        continueCheck = true;
        while (continueCheck)
        {
            if (newX >= 0)
            {
                if (squares[positionY, newX].GetPiece() == null)
                {
                    squaresToReturn.Add(squares[positionY, newX]);
                    buttonGrids.SetBool(newX, positionY);
                    newX = newX - 1;
                }
                else
                {
                    continueCheck = false;
                    if (squares[positionY, newX].GetPiece().GetColour() == true)
                    {
                        squaresToReturn.Add(squares[positionY, newX]);
                        buttonGrids.SetBool(newX, positionY);
                    }
                }
            }
            else
            {
                continueCheck = false;
            }
        }
        newY = positionY + 1;
        continueCheck = true;
        while (continueCheck)
        {
            if (newY < 8)
            {
                if (squares[newY, positionX].GetPiece() == null)
                {
                    squaresToReturn.Add(squares[newY, positionX]);
                    buttonGrids.SetBool(positionX, newY);
                    newY = newY + 1;
                }
                else
                {
                    continueCheck = false;
                    if (squares[newY, positionX].GetPiece().GetColour() == true)
                    {
                        squaresToReturn.Add(squares[newY, positionX]);
                        buttonGrids.SetBool(positionX, newY);
                    }
                }
            }
            else
            {
                continueCheck = false;
            }
        }
        newY = positionY - 1;
        continueCheck = true;
        while (continueCheck)
        {
            if (newY >= 0)
            {
                if (squares[newY, positionX].GetPiece() == null)
                {
                    squaresToReturn.Add(squares[newY, positionX]);
                    buttonGrids.SetBool(positionX, newY);
                    newY = newY - 1;
                }
                else
                {
                    continueCheck = false;
                    if (squares[newY, positionX].GetPiece().GetColour() == true)
                    {
                        squaresToReturn.Add(squares[newY, positionX]);
                        buttonGrids.SetBool(positionX, newY);
                    }
                }
            }
            else
            {
                continueCheck = false;
            }
        }
        newY = positionY + 1;
        newX = positionX + 1;
        continueCheck = true;
        while (continueCheck)
        {
            if (newX < 8 && newY < 8)
            {
                if (squares[newY, newX].GetPiece() == null)
                {
                    squaresToReturn.Add(squares[newY, newX]);
                    buttonGrids.SetBool(newX, newY);
                    newX = newX + 1;
                    newY = newY + 1;
                }
                else
                {
                    continueCheck = false;
                    if (squares[newY, newX].GetPiece().GetColour() == true)
                    {
                        squaresToReturn.Add(squares[newY, newX]);
                        buttonGrids.SetBool(newX, newY);
                    }
                }
            }
            else
            {
                continueCheck = false;
            }
        }
        newX = positionX - 1;
        newY = positionY + 1;
        continueCheck = true;
        while (continueCheck)
        {
            if (newX >= 0 && newY < 8)
            {
                if (squares[newY, newX].GetPiece() == null)
                {
                    squaresToReturn.Add(squares[newY, newX]);
                    buttonGrids.SetBool(newX, newY);
                    newX = newX - 1;
                    newY = newY + 1;
                }
                else
                {
                    continueCheck = false;
                    if (squares[newY, newX].GetPiece().GetColour() == true)
                    {
                        squaresToReturn.Add(squares[newY, newX]);
                        buttonGrids.SetBool(newX, newY);
                    }
                }
            }
            else
            {
                continueCheck = false;
            }
        }
        newX = positionX + 1;
        newY = positionY - 1;
        continueCheck = true;
        while (continueCheck)
        {
            if (newX < 8 && newY >= 0)
            {
                if (squares[newY, newX].GetPiece() == null)
                {
                    squaresToReturn.Add(squares[newY, newX]);
                    buttonGrids.SetBool(newX, newY);
                    newX = newX + 1;
                    newY = newY - 1;
                }
                else
                {
                    continueCheck = false;
                    if (squares[newY, newX].GetPiece().GetColour() == true)
                    {
                        squaresToReturn.Add(squares[newY, newX]);
                        buttonGrids.SetBool(newX, newY);
                    }
                }
            }
            else
            {
                continueCheck = false;
            }
        }
        newX = positionX - 1;
        newY = positionY - 1;
        continueCheck = true;
        while (continueCheck)
        {
            if (newX >= 0 && newY >= 0)
            {
                if (squares[newY, newX].GetPiece() == null)
                {
                    squaresToReturn.Add(squares[newY, newX]);
                    buttonGrids.SetBool(newX, newY);
                    newX = newX - 1;
                    newY = newY - 1;
                }
                else
                {
                    continueCheck = false;
                    if (squares[newY, newX].GetPiece().GetColour() == true)
                    {
                        squaresToReturn.Add(squares[newY, newX]);
                        buttonGrids.SetBool(newX, newY);
                    }
                }
            }
            else
            {
                continueCheck = false;
            }
        }
        return squaresToReturn;
    }

    public override List<boardSquares> CheckMoveBlack(boardSquares[,] squares)
    {
        List<boardSquares> squaresToReturn = new List<boardSquares>();
        int newY = positionY;
        int newX = positionX + 1;
        bool continueCheck = true;
        while (continueCheck)
        {
            if (newX < 8)
            {
                if (squares[positionY, newX].GetPiece() == null)
                {
                    squaresToReturn.Add(squares[positionY, newX]);
                    buttonGrids.SetBool(newX, positionY);
                    newX = newX + 1;
                }
                else
                {
                    continueCheck = false;
                    if (squares[positionY, newX].GetPiece().GetColour() == false)
                    {
                        squaresToReturn.Add(squares[positionY, newX]);
                        buttonGrids.SetBool(newX, positionY);
                    }
                }
            }
            else
            {
                continueCheck = false;
            }
        }
        newX = positionX - 1;
        continueCheck = true;
        while (continueCheck)
        {
            if (newX >= 0)
            {
                if (squares[positionY, newX].GetPiece() == null)
                {
                    squaresToReturn.Add(squares[positionY, newX]);
                    buttonGrids.SetBool(newX, positionY);
                    newX = newX - 1;
                }
                else
                {
                    continueCheck = false;
                    if (squares[positionY, newX].GetPiece().GetColour() == false)
                    {
                        squaresToReturn.Add(squares[positionY, newX]);
                        buttonGrids.SetBool(newX, positionY);
                    }
                }
            }
            else
            {
                continueCheck = false;
            }
        }
        newY = positionY + 1;
        continueCheck = true;
        while (continueCheck)
        {
            if (newY < 8)
            {
                if (squares[newY, positionX].GetPiece() == null)
                {
                    squaresToReturn.Add(squares[newY, positionX]);
                    buttonGrids.SetBool(positionX, newY);
                    newY = newY + 1;
                }
                else
                {
                    continueCheck = false;
                    if (squares[newY, positionX].GetPiece().GetColour() == false)
                    {
                        squaresToReturn.Add(squares[newY, positionX]);
                        buttonGrids.SetBool(positionX, newY);
                    }
                }
            }
            else
            {
                continueCheck = false;
            }
        }
        newY = positionY - 1;
        continueCheck = true;
        while (continueCheck)
        {
            if (newY >= 0)
            {
                if (squares[newY, positionX].GetPiece() == null)
                {
                    squaresToReturn.Add(squares[newY, positionX]);
                    buttonGrids.SetBool(positionX, newY);
                    newY = newY - 1;
                }
                else
                {
                    continueCheck = false;
                    if (squares[newY, positionX].GetPiece().GetColour() == false)
                    {
                        squaresToReturn.Add(squares[newY, positionX]);
                        buttonGrids.SetBool(positionX, newY);
                    }
                }
            }
            else
            {
                continueCheck = false;
            }
        }
        newY = positionY + 1;
        newX = positionX + 1;
        continueCheck = true;
        while (continueCheck)
        {
            if (newX < 8 && newY < 8)
            {
                if (squares[newY, newX].GetPiece() == null)
                {
                    squaresToReturn.Add(squares[newY, newX]);
                    buttonGrids.SetBool(newX, newY);
                    newX = newX + 1;
                    newY = newY + 1;
                }
                else
                {
                    continueCheck = false;
                    if (squares[newY, newX].GetPiece().GetColour() == false)
                    {
                        squaresToReturn.Add(squares[newY, newX]);
                        buttonGrids.SetBool(newX, newY);
                    }
                }
            }
            else
            {
                continueCheck = false;
            }
        }
        newX = positionX - 1;
        newY = positionY + 1;
        continueCheck = true;
        while (continueCheck)
        {
            if (newX >= 0 && newY < 8)
            {
                if (squares[newY, newX].GetPiece() == null)
                {
                    squaresToReturn.Add(squares[newY, newX]);
                    buttonGrids.SetBool(newX, newY);
                    newX = newX - 1;
                    newY = newY + 1;
                }
                else
                {
                    continueCheck = false;
                    if (squares[newY, newX].GetPiece().GetColour() == false)
                    {
                        squaresToReturn.Add(squares[newY, newX]);
                        buttonGrids.SetBool(newX, newY);
                    }
                }
            }
            else
            {
                continueCheck = false;
            }
        }
        newX = positionX + 1;
        newY = positionY - 1;
        continueCheck = true;
        while (continueCheck)
        {
            if (newX < 8 && newY >= 0)
            {
                if (squares[newY, newX].GetPiece() == null)
                {
                    squaresToReturn.Add(squares[newY, newX]);
                    buttonGrids.SetBool(newX, newY);
                    newX = newX + 1;
                    newY = newY - 1;
                }
                else
                {
                    continueCheck = false;
                    if (squares[newY, newX].GetPiece().GetColour() == false)
                    {
                        squaresToReturn.Add(squares[newY, newX]);
                        buttonGrids.SetBool(newX, newY);
                    }
                }
            }
            else
            {
                continueCheck = false;
            }
        }
        newX = positionX - 1;
        newY = positionY - 1;
        continueCheck = true;
        while (continueCheck)
        {
            if (newX >= 0 && newY >= 0)
            {
                if (squares[newY, newX].GetPiece() == null)
                {
                    squaresToReturn.Add(squares[newY, newX]);
                    buttonGrids.SetBool(newX, newY);
                    newX = newX - 1;
                    newY = newY - 1;
                }
                else
                {
                    continueCheck = false;
                    if (squares[newY, newX].GetPiece().GetColour() == false)
                    {
                        squaresToReturn.Add(squares[newY, newX]);
                        buttonGrids.SetBool(newX, newY);
                    }
                }
            }
            else
            {
                continueCheck = false;
            }
        }
        return squaresToReturn;
    }
}

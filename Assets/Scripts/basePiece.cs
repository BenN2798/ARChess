using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class basePiece : MonoBehaviour
{
    public enum pieceType { pawn, rook, knight, bishop, queen, king};
    public pieceType typeOfPiece;
    public int positionX;
    public int positionY;
    public buttonGridController buttonGrids;
    public int id;
    public bool dark;
    public bool moved = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual List<boardSquares> CheckMoveWhite(boardSquares[,] squares)
    {
        return new List<boardSquares>();
    }

    public virtual List<boardSquares> CheckMoveBlack(boardSquares[,] squares)
    {
        return new List<boardSquares>();
    }

    public void SetPosition(int x, int y)
    {
        positionX = x;
        positionY = y;
        moved = true;
    }

    public int GetX()
    {
        return positionX;
    }

    public int GetY()
    {
        return positionY;
    }

    public int GetID()
    {
        return id;
    }

    public bool GetColour()
    {
        return dark;
    }

    public pieceType GetPieceType()
    {
        return typeOfPiece;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;
using GoogleARCore.Examples.Common;

public class chessController : MonoBehaviour
{
    public boardPoint[] ChessBoardPoints;
    public basePiece[] WhitePieces;
    public basePiece[] DarkPieces;
    public GameObject WhiteQueen;
    public GameObject BlackQueen;
    boardSquares[,] ChessBoardSquares;
    public buttonGridController buttonGrids;
    public UIManager ui;
    basePiece pieceToMove = null;

    // Start is called before the first frame update
    void Start()
    {
        buttonGrids = FindObjectOfType<buttonGridController>();
        ui = FindObjectOfType<UIManager>();
        ui.UpDateUI(WhitePieces, DarkPieces);
        ChessBoardSquares = new boardSquares[8, 8];
        int x = 0;
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                ChessBoardSquares[i, j] = new boardSquares(ChessBoardPoints[x], j, i);
                ChessBoardSquares[i, j].GetPoint().gameObject.SetActive(false);
                x = x + 1;
            }
        }
        x = 0;
        for (int i = 1; i >= 0; i--)
        {
            for (int j = 0; j < 8; j++)
            {
                ChessBoardSquares[i, j].SetPiece(WhitePieces[x]);
                x = x + 1;
            }
        }
        x = 0;
        for (int i = 6; i <= 7; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                ChessBoardSquares[i, j].SetPiece(DarkPieces[x]);
                x = x + 1;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        buttonGrids = FindObjectOfType<buttonGridController>();
        ui = FindObjectOfType<UIManager>();
    }

    public void CheckWhiteMove(int pieceToCheck)
    {
        buttonGrids.ResetBools();
        foreach (boardPoint point in ChessBoardPoints)
        {
            point.gameObject.SetActive(false);
        }
        pieceToMove = WhitePieces[pieceToCheck];
        if (pieceToMove != null)
        {
            List<boardSquares> availableMoves = pieceToMove.CheckMoveWhite(ChessBoardSquares);
            foreach (boardSquares square in availableMoves)
            {
                square.GetPoint().gameObject.SetActive(true);
            }
            buttonGrids.Display();
        }
    }

    public void CheckBlackMove(int pieceToCheck)
    {
        buttonGrids.ResetBools();
        foreach (boardPoint point in ChessBoardPoints)
        {
            point.gameObject.SetActive(false);
        }
        pieceToMove = DarkPieces[pieceToCheck];
        if (pieceToMove != null)
        {
            List<boardSquares> availableMoves = pieceToMove.CheckMoveBlack(ChessBoardSquares);
            foreach (boardSquares square in availableMoves)
            {
                square.GetPoint().gameObject.SetActive(true);
            }
            buttonGrids.Display();
        }
    }

    public void MovePiece(int x, int y)
    {
        bool win = false;
        if (pieceToMove != null)
        {
            ChessBoardSquares[pieceToMove.GetY(), pieceToMove.GetX()].SetPiece(null);
            if (ChessBoardSquares[y, x].GetPiece() != null)
            {
                int id = ChessBoardSquares[y, x].GetPiece().GetID();
                if (ChessBoardSquares[y, x].GetPiece().GetPieceType() == basePiece.pieceType.king)
                {
                    win = true;
                }
                basePiece takenPiece = null;
                if (pieceToMove.GetColour() == true)
                {
                    takenPiece = WhitePieces[id];
                    WhitePieces[id] = null;
                }
                else
                {
                    takenPiece = DarkPieces[id];
                    DarkPieces[id] = null;
                }
                Destroy(takenPiece.gameObject);
                pieceToMove.SetPosition(x, y);
                ChessBoardSquares[y, x].SetPiece(pieceToMove);
                pieceToMove.transform.position = ChessBoardSquares[y, x].GetPoint().gameObject.transform.position;
            }
            else
            {
                pieceToMove.SetPosition(x, y);
                ChessBoardSquares[y, x].SetPiece(pieceToMove);
                pieceToMove.transform.position = ChessBoardSquares[y, x].GetPoint().gameObject.transform.position;
            }
            buttonGrids.ResetBools();
            buttonGrids.Display();
            foreach (boardPoint point in ChessBoardPoints)
            {
                point.gameObject.SetActive(false);
            }
            if (pieceToMove.GetPieceType() == basePiece.pieceType.pawn)
            {
                if (pieceToMove.GetColour() == true)
                {
                    if (y == 0)
                    {
                        QueenPawn(x, y);
                    }
                }
                else
                {
                    if (y == 7)
                    {
                        QueenPawn(x, y);
                    }
                }
            }
            if (win == false)
            {
                ui.UpDateUI(WhitePieces, DarkPieces);
            }
            else
            {
                ui.Win();
            }
        }
    }
    
    public void QueenPawn(int x, int y)
    {
        queen _queen;
        if (pieceToMove.GetColour() == true)
        {
            _queen = Instantiate(BlackQueen, pieceToMove.gameObject.transform.position, pieceToMove.gameObject.transform.rotation).GetComponent<queen>();
            DarkPieces[pieceToMove.GetID()] = _queen;
        }
        else
        {
            _queen = Instantiate(WhiteQueen, pieceToMove.gameObject.transform.position, pieceToMove.gameObject.transform.rotation).GetComponent<queen>();
            WhitePieces[pieceToMove.GetID()] = _queen;
        }
        _queen.ConvertFromPawn(x, y, pieceToMove.GetID(), pieceToMove.GetColour());
        _queen.SetPosition(x, y);
        ChessBoardSquares[y, x].SetPiece(_queen);
        Destroy(pieceToMove.gameObject);
    }
}

public class boardSquares
{
    boardPoint point;
    Vector3 location;
    basePiece pieceAtPoint;
    int positionX;
    int positionY;

    public boardSquares()
    {

    }

    public boardSquares(boardPoint _point, int x, int y)
    {
        point = _point;
        location = point.transform.position;
        positionX = x;
        positionY = y;
    }

    public boardPoint GetPoint()
    {
        return point;
    }

    public void SetPiece(basePiece _piece)
    {
        pieceAtPoint = _piece;
    }

    public basePiece GetPiece()
    {
        return pieceAtPoint;
    }
}

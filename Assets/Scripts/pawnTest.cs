using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pawnTest : MonoBehaviour
{
    public Button pButton;
    public int pawn;
    public chessController board;
    public bool dark;


    // Start is called before the first frame update
    void Start()
    {
        pButton.onClick.AddListener(OnBtnClick);
        board = FindObjectOfType<chessController>();
    }

    // Update is called once per frame
    void Update()
    {
        board = FindObjectOfType<chessController>();
    }

    public void OnBtnClick()
    {
        Debug.Log("Clicked");
        if (board != null)
        {
            if (dark == true)
            {
                board.CheckBlackMove(pawn);
            }
            else
            {
                board.CheckWhiteMove(pawn);
            }
        }
    }

}

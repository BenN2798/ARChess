using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gridClick : MonoBehaviour
{
    public Button pButton;
    public int x;
    public int y;
    public chessController board;

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
            board.MovePiece(x, y);
        }
    }
}

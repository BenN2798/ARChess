using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button[] WhiteButtons;
    public Button[] DarkButtons;
    public Text display;
    bool playerTurn = true; //false is player 1, true is player 2
    bool win = false;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Button button in WhiteButtons)
        {
            button.gameObject.SetActive(false);
        }
        foreach (Button button in DarkButtons)
        {
            button.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpDateUI(basePiece[] whitePieces, basePiece[] blackPieces)
    {
        if (win == false)
        {
            if (playerTurn == false)
            {
                playerTurn = true;
                foreach (Button button in WhiteButtons)
                {
                    button.gameObject.SetActive(false);
                }
                for (int i = 0; i < 16; i++)
                {
                    if (blackPieces[i] != null)
                    {
                        DarkButtons[i].gameObject.SetActive(true);
                    }
                    else
                    {
                        DarkButtons[i].gameObject.SetActive(true);
                    }
                }
                display.text = "Player 2's Turn";
            }
            else
            {
                playerTurn = false;
                foreach (Button button in DarkButtons)
                {
                    button.gameObject.SetActive(false);
                }
                for (int i = 0; i < 16; i++)
                {
                    if (whitePieces[i] != null)
                    {
                        WhiteButtons[i].gameObject.SetActive(true);
                    }
                    else
                    {
                        WhiteButtons[i].gameObject.SetActive(true);
                    }
                }
                display.text = "Player 1's Turn";
            }
        }
    }

    public void Win()
    {
        win = true;
        foreach (Button button in WhiteButtons)
        {
            button.gameObject.SetActive(false);
        }
        foreach (Button button in DarkButtons)
        {
            button.gameObject.SetActive(false);
        }
        if (playerTurn == false)
        {
            display.text = "Player 1 Wins";
        }
        else
        {
            display.text = "Player 2 Wins";
        }
    }
}

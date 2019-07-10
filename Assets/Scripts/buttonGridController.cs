using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonGridController : MonoBehaviour
{
    public Button[] buttons;
    Button[,] buttonGrid;
    bool[,] buttonsActive;

    // Start is called before the first frame update
    void Start()
    {
        buttonsActive = new bool[8, 8];
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                buttonsActive[i, j] = false;
                Debug.Log(buttonsActive[i, j]);
            }
        }
        buttonGrid = new Button[8, 8];
        int x = 0;
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                buttonGrid[i, j] = buttons[x];
                buttonGrid[i, j].gameObject.SetActive(false);
                x = x + 1;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetBools()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                buttonsActive[i, j] = false;
            }
        }
    }

    public void SetBool(int x, int y)
    {
        buttonsActive[y, x] = true;
    }

    public void Display()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (buttonsActive[i, j] == true)
                {
                    buttonGrid[i, j].gameObject.SetActive(true);
                }
                else
                {
                    buttonGrid[i, j].gameObject.SetActive(false);
                }
            }
        }
    }
}

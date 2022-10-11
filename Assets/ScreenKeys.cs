﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenKeys : MonoBehaviour
{
    GameObject[,] keyBoxes = new GameObject[3,3];

    private void Awake()
    {
        int i = 0;
        for(int row = 0; row <= 2; row++)
        {
            for(int col = 0; col <= 2; col++)
            {
                keyBoxes[row, col] = transform.GetChild(i).gameObject;
                i++;
                //print("Obj:" + transform.GetChild(i).gameObject + " Row:" + row + " Col:" + col);
            }
        }
    }

    public void highlightKey(Vector2 keyToLight)
    {
        ResetWhite();

        int arrayX = (int)keyToLight.x;     //Array can't take float
        int arrayY = (int)keyToLight.y;

        keyBoxes[arrayX, arrayY].GetComponent<Image>().color = Color.green;

        //print(arrayX + ", " + arrayY + " = Green");
    }

    public void ResetWhite()
    {
        int i = 1;
        for (int row = 0; row <= 2; row++)
        {
            for (int col = 0; col <= 2; col++)
            {
                keyBoxes[row, col].GetComponent<Image>().color = Color.white;
            }
            i++;
        }
    }
}
